// Check lại Radio (>= 2 lựa chọn) theo giá trị của input
function CheckInputRadioByValue() {
    var arrInput = listInputRadio.split(',');
    for (var i = 0; i < arrInput.length; i++) {
        var number = $("#" + arrInput[i]).val(); // lấy giá trị
        $("#rd_value_" + arrInput[i] + "_" + number).attr("checked", true);
    }
}

// Enable các trường dữ liệu cần nhập lại, dùng cho loại > 2 đáp án
function EnableInputRadio() {
    var strTruongNhapLai = $("#TruongNhapLai").val();
    var arrInput_ID = strTruongNhapLai.split(',');
    for (var i = 0; i < arrInput_ID.length - 1; i++) {        
        if (listInputRadio.indexOf(arrInput_ID[i]) != -1) {
            $("input[name='rd_value_" + arrInput_ID[i] + "']").attr("disabled", false); // Trường hợp là Input là radio , để Disabled
        }
        else {
            $("input[name='" + arrInput_ID[i] + "']").attr("readonly", false); // Trường hợp Input là TextBox, để Readonly vì Disabled, textbox không nhận giá trị
        }
        $("label[for='" + arrInput_ID[i] + "']").css('color', 'red'); // Bôi màu đỏ label của các trường dữ liệu sai (cần nhập lại)
    }
}

// ******* Dùng cho View Check (Xóa dữ liệu Trường nhập lại)  ***********
// Chỉnh css html cho các trường dữ liệu đã sửa
// Đặt dưới cùng vì hàm này set lại trường nhập lại = null
function SetIncorectHtml() {
    var strTruongNhapLai = $("#TruongNhapLai").val();
    if (strTruongNhapLai != "") {
        var arrInput_ID = strTruongNhapLai.split(',');
        var arrLabel = "";
        for (var i = 0; i < arrInput_ID.length - 1; i++) {
            var label = $('label[for="' + arrInput_ID[i] + '"]').html();
            arrLabel += label + ",";
            $("#" + arrInput_ID[i]).css('color', 'red');
            $("label[for='" + arrInput_ID[i] + "']").css('color', 'red');
        }
        //$("#txtTruongNhapLai").val(arrLabel);
    }
    // Set gia tri ve null
    $("#TruongNhapLai").val("");
    $("#txtTruongNhapLai").val(""); // Khi mở View Check, nội dung trường nhập lại sẽ xóa để tránh duplicate dữ liệu
}

// ******* Dùng cho View Edit (Không xóa dữ liệu Trường nhập lại)  ***********
// Chỉnh css html cho các trường dữ liệu đã sửa
function GetLabelInputIncorrectHtml() {
    var strTruongNhapLai = $("#TruongNhapLai").val();
    if (strTruongNhapLai != "") {
        var arrInput_ID = strTruongNhapLai.split(',');
        var arrLabel = "";
        for (var i = 0; i < arrInput_ID.length - 1; i++) {
            var label = $('label[for="' + arrInput_ID[i] + '"]').html();
            arrLabel += label + ",";
            $("#" + arrInput_ID[i]).css('color', 'red');
            $("label[for='" + arrInput_ID[i] + "']").css('color', 'red');
        }
        $("#txtTruongNhapLai").val(arrLabel);
    }
}

// không dùng nữa
// Check lại radio Yes/No theo giá trị của input
//function CheckRadioByInputValue() {
//    var arrInput = listInputRadio.split(',');
//    for (var i = 0; i < arrInput.length; i++) {
//        if ($("#" + arrInput[i]).val() == 1) {
//            $("#rd_value_" + arrInput[i] + "_Yes").attr("checked", true);
//        } else if ($("#" + arrInput[i]).val() == 0) {
//            $("#rd_value_" + arrInput[i] + "_No").attr("checked", true);
//        }
//    }
//}

// không dùng nữa
// Enable các trường dữ liệu cần nhập lại
//function EnableInput() {
//    var strTruongNhapLai = $("#TruongNhapLai").val();
//    var arrInput_ID = strTruongNhapLai.split(',');
//    for (var i = 0; i < arrInput_ID.length - 1; i++) {
//        // Trường hợp là input là radio
//        if (listInputRadio.indexOf(arrInput_ID[i]) != -1) {
//            $("#rd_value_" + arrInput_ID[i] + "_No").attr("disabled", false);
//            $("#rd_value_" + arrInput_ID[i] + "_Yes").attr("disabled", false);
//        } else {
//            $("#" + arrInput_ID[i]).attr("readonly", false);
//            $("#" + arrInput_ID[i]).css('color', 'red');
//        }
//        $("label[for='" + arrInput_ID[i] + "']").css('color', 'red');
//    }
//}

// Kendo Datepicker
// create DatePicker from input HTML element
function startChange() {
    var startDate = start.value(),
    endDate = end.value();

    if (startDate) {
        startDate = new Date(startDate);
        startDate.setDate(startDate.getDate());
        end.min(startDate);
    } else if (endDate) {
        start.max(new Date(endDate));
    } else {
        endDate = new Date();
        start.max(endDate);
        end.min(endDate);
    }
}

function endChange() {
    var endDate = end.value(),
    startDate = start.value();

    if (endDate) {
        endDate = new Date(endDate);
        endDate.setDate(endDate.getDate());
        start.max(endDate);
    } else if (startDate) {
        end.min(new Date(startDate));
    } else {
        endDate = new Date();
        start.max(endDate);
        end.min(endDate);
    }
}

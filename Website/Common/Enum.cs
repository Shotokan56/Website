using System.Runtime.Serialization;


namespace Website.Common
{
    public class TrangThai
    {
        public const int HoatDong = 1;
        public const int KhongHoatDong = 2;
    }

    public enum SecurityRoles
    {
        [EnumMember] 
        Admin,
        [EnumMember]
        Member,
    }
}
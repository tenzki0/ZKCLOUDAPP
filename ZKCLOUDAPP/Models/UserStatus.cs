using System.ComponentModel;

namespace ZKCLOUDAPP
{
    public enum UserStatus
    {
        [Description("Zatwierdzony")]
        Approved,
        [Description("Nie zatwierdzony")]
        NotApproved ,
        [Description("Zablokowany")]
        Blocked,
        [Description("Czynny")]
        Active
    }
}

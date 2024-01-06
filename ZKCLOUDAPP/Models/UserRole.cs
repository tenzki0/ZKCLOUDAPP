using System.ComponentModel;

namespace ZKCLOUDAPP
{
    public enum UserRole
    {
        [Description("Aministrator eMG")]
        eMGAdministrator,
        [Description("Administrator")]
        Admin,
        [Description("Użytkownik")]
        User,
        [Description("Gość")]
        Guest
    }
}

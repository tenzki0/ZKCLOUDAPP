using System.ComponentModel.DataAnnotations;

namespace ZKCLOUDAPP
{
    public class User
    {
        [Display(Name = "Identyfikator rekordu")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Pole login powinno być wypełnione")]
        public string? Login { get; set; }

        //[Required(ErrorMessage = "Pole z hasłem powinno być wypełnione")]
        public string? Password { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Pole z pocztą elektroniczną powinno być wpisane")]
        public string? Email { get; set; }

        [Display(Name = "Numer komórkowy")]
        [Required(ErrorMessage = "Numer komórkowy powinien być wpisany")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Numer komórkowy zawiera tylko 9 znaków, proszę wpisać bez kodu kraju")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Imię powinno być wpisane")]
        [StringLength(36, MinimumLength = 2, ErrorMessage = "Imię powinno być dłuższe niż 2 znaki oraz krótrze niż 36 znaków")]
        public string? FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko powinno być wpisane")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Nazwisko powinno być dłuższe niż 2 znaki oraz krótrze niż 64 znaków")]
        public string? LastName { get; set; }

        [Display(Name = "Status")]
        public UserStatus UserStatus { get; set; } = UserStatus.Active;

        [Display(Name = "Rola")]
        public UserRole UserRole { get; set; } = UserRole.User;
    }
}

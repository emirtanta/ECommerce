using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email adresi zorunludur")]
        [Display(Name ="Email Adres")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

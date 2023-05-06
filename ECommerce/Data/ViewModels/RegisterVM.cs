using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerce.Data.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Ad Soyad zorunludur")]
        [Display(Name ="Ad Soyad")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Email adresi zorunludur")]
        [Display(Name ="Email Adres")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Şifre tekrar alanı zorunludur")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}

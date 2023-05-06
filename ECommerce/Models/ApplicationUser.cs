using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name ="Ad Soyad")]
        public string FullName { get; set; }
    }
}

using ECommerce.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profil Resmi")]
        [Required(ErrorMessage ="Profil resmi gereklidir")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage ="Ad Soyad zorunludur")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Ad soyad en az 3 en fazla 50 karakter olabilir")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Biyografi girilmesi zorunludur")]
        [Display(Name = "Biyografi")]
        public string Bio { get; set; }

        //ilişkiler
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

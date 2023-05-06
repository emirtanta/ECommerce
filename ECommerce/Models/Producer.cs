using ECommerce.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Yapımcı resmi zorunludur")]
        [Display(Name ="Profil Resmi")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Yapımcı adı soyadı zorunludur")]
        [Display(Name = "Ad Soyad")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Ad soyad en az 3 en fazla 50 karakterden oluşmalıdır")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Yapımcı biyografisi zorunludur")]
        [Display(Name = "Açıklama")]
        public string Bio { get; set; }

        //ilişkiler
        public List<Movie>  Movies { get; set; }
    }
}

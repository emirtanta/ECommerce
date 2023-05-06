using ECommerce.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Logo zorunludur")]
        [Display(Name ="Logo")]
        public string Logo { get; set; }

        [Required(ErrorMessage ="Sinema adı zorunludur")]
        [Display(Name = "Sinema Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sinema açıklaması zorunludur")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        //ilişikler
        public List<Movie> Movies { get; set; }
    }
}

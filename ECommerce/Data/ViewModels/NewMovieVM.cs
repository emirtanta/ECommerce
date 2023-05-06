using ECommerce.Data.Base;
using ECommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunludur")]
        [Display(Name="Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı zorunludur")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat alanı zorunludur")]
        [Display(Name = "Fiyat")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Resim alanı zorunludur")]
        [Display(Name = "Resim")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Başlangıç Tarihi alanı zorunludur")]
        [Display(Name = "Film Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Bitiş Tarihi alanı zorunludur")]
        [Display(Name = "Film Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Fil Kategori alanı zorunludur")]
        [Display(Name = "Kategori Seçiniz")]
        public MovieCategory MovieCategory { get; set; }

        //ilişkiler
        [Required(ErrorMessage = "Film aktörleri alanı zorunludur")]
        [Display(Name = "Aktör Seçiniz")]
        public List<int> ActorsIds { get; set; }

        //cinema
        [Required(ErrorMessage = "Sinema alanı zorunludur")]
        [Display(Name = "Sinema Seçiniz")]
        public int CinemaId { get; set; }

        //Producer
        [Required(ErrorMessage = "Yapımcı alanı zorunludur")]
        [Display(Name = "Yapımcı Seçiniz")]
        public int ProducerId { get; set; }
    }
}

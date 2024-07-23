using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.ViewModels
{
    public class CreditCardViewModel
    {
        [Required(ErrorMessage = "Kart numarası gereklidir.")]
        [StringLength(19, MinimumLength = 13, ErrorMessage = "Kart numarası geçersiz.")]
        [Display(Name = "Kart Numarası")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Son kullanma tarihi gereklidir.")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Geçersiz tarih formatı. MM/YY şeklinde giriniz.")]
        [Display(Name = "Son Kullanma Tarihi")]
        public string ExpiryDate { get; set; }

        [Required(ErrorMessage = "CVC kodu gereklidir.")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Geçersiz CVC kodu.")]
        [Display(Name = "CVC")]
        public string Cvc { get; set; }
    }
}

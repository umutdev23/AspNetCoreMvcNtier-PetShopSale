using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.ViewModels
{
    public class AddressViewModel
    {
        [Required(ErrorMessage = "Ad gereklidir.")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad gereklidir.")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Ülke gereklidir.")]
        [StringLength(100, ErrorMessage = "Ülke adı en fazla 100 karakter olabilir.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Adres gereklidir.")]
        [StringLength(200, ErrorMessage = "Adres en fazla 200 karakter olabilir.")]
        public string StreetAddress { get; set; }



        [Required(ErrorMessage = "Şehir gereklidir.")]
        [StringLength(100, ErrorMessage = "Şehir adı en fazla 100 karakter olabilir.")]
        public string City { get; set; }






        [Required(ErrorMessage = "Telefon numarası gereklidir.")]
        [StringLength(15, ErrorMessage = "Telefon numarası en fazla 15 karakter olabilir.")]

        public string Phone { get; set; }

        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        [StringLength(100, ErrorMessage = "E-posta adresi en fazla 100 karakter olabilir.")]
        public string Email { get; set; }
    }

}

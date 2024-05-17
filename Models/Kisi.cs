using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace miracApp.Models
{
    public class Kisi
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Soyad boş bırakılamaz")]
        [Display(Name = "Ad Soyad")]
        [StringLength(20)]
        
        public string AdSoyad { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        [StringLength(200)]

        public string Email { get; set; }
        [StringLength(15)]

        public string Telefon { get; set; }

    }
}
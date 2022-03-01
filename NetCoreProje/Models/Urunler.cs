using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Models
{
    public class Urunler
    {
        [Key]
        public int UrunNo { get; set; }

        [Required]
        [DisplayName("Ürün Adı")]
        public string UrunAd { get; set; }
        [Required]
        [DisplayName("Alış Fiyatı")]
        public decimal AlisFiyat { get; set; }
        [Required]
        [DisplayName("Satış Fiyatı")]
        public decimal SatisFiyat { get; set; }
        [Required]
        public int Miktar { get; set; }
        [Required]
        [DisplayName("Reyon Numarası")]
        public int ReyonNo { get; set; }
    }
}

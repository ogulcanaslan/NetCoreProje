using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Models
{
    public class Personel
    {
        [Key]
        public int PersonelNo { get; set; }
        [Required,StringLength(50)]
        [DisplayName("Ad Soyad")]
        public string AdSoyad { get; set; }
        [Required]
        [DisplayName("Maaş")]
        public decimal Maas { get; set; }
        [DisplayName("Reyon Numarası")]
        public int ReyonNo { get; set; }
    }
}

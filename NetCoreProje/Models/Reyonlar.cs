using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Models
{
    public class Reyonlar
    {
        [Key]
        public int ReyonNo { get; set; }

        [Required]
        [DisplayName("Reyon Adı")]
        public string ReyonAdi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspDers.Models
{
    public class BakimTipi
    {
        public int Id { get; set; }

        [Required]
        public string BakimAdi { get; set; }
        [Required]
        public double BakimFiyati { get; set; }

    }
}

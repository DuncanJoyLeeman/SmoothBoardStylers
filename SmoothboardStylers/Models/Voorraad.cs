using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Models
{
    public class Voorraad
    {
        [ForeignKey("Surfboard")]
        public int SurfboardId { get; set; }

        public Surfboard  Surfboard{ get; set; }

        [ForeignKey("Filiaal")]
        public int FiliaalId { get; set; }

        public Filiaal Filiaal { get; set; }

        public int Aantal { get; set; }
    }
}

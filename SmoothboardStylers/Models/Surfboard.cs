using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Models
{
    public class Surfboard
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Prijs { get; set; }
        public string FotoUrl { get; set; }
        
        [ForeignKey("Materiaal")]
        public int MateriaalId { get; set; }
        public virtual Materiaal Materiaal { get; set; }
    }
}

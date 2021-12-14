using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Models
{
    public class Materiaal
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Models
{
    public class Interesse
    {
        public int Id { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }

        public Contact Contact { get; set; }

        [ForeignKey("Surfboard")]
        public int SurfboardId { get; set; }

        public Surfboard Surfboard { get; set; }

        [DefaultValue(false)]
        public bool Behandeld { get; set; }
    }
}

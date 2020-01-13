using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seguritas.Core
{

    public partial class Coberturas
    {
        public Coberturas()
        {
            Planes = new HashSet<Planes>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}

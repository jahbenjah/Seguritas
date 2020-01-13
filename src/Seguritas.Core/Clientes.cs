using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seguritas.Core
{
    public partial class Clientes
    {
        public Clientes()
        {
            Planes = new HashSet<Planes>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}

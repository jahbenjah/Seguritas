using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seguritas.Core
{
    public partial class Planes
    {
        public Planes()
        {
            Clientes = new HashSet<Clientes>();
            Coberturas = new HashSet<Coberturas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }

        public virtual ICollection<Coberturas> Coberturas { get; set; }
    }
}

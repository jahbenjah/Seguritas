using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguritas.Api.Models
{
    public class ClientesDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime? FechaModificacion { get; set; }

    }
}
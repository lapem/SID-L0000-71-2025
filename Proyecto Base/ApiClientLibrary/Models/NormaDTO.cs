using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{
    public class NormaDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Clave { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Edicion { get; set; } = string.Empty;

        public string Estatus { get; set; } = string.Empty;

        public bool EsCFE { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}

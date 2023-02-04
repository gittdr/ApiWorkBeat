using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkBeat.Models
{
    public class DatosNomina
    {
        public int idRazonSocial { get; set; }
        public string RazonSocial { get; set; }
        public string rfcRazonSocial { get; set; }
        public string fechaBajaRazonSocial { get; set; }
        public int estatus { get; set; }
        public string numeroEmpleado { get; set; }

    }
}

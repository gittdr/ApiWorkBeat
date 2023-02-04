using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkBeat.Models
{
    public class MovimientosPersonal
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellidoPat { get; set; }
        public string apellidoMat { get; set; }
        public string fecha { get; set; }
        public string tipoMovimiento { get; set; }
        public List<Posicion> posicion { get; set; }
        public string motivoBaja { get; set; }
        public int? idCausaBajaIMSS { get; set; }
        public int? causaBajaIMSS { get; set; }
        public string observaciones { get; set; }
        public string fechaBaja { get; set; }
        public string fechaCaptura { get; set; }
        public string fechaIngresoPosición { get; set; }
        public string fechaIngresoOrganizacion { get; set; }
        public List<DatosNomina> datosNomina { get; set; }


    }
}

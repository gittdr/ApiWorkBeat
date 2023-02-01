using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkBeat.Models
{
    public class GetInfo
    {
        public int idTenant { get; set; }
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string Puesto { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string NumEmpleado { get; set; }
        public string RegistroPatronal { get; set; }
        public string apellidoPat { get; set; }
        public string apellidoMat { get; set; }
        public string fechaIngreso { get; set; }
        public decimal SalarioDiarioIntegrado { get; set; }
        public decimal SalarioDiario { get; set; }
        public string GUID { get; set; }
        public string GUIDExpediente { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string failedAttempts { get; set; }
        public string blockedUntil { get; set; }
        public RazonSocial razonsocial { get; set; }
       
    }
}

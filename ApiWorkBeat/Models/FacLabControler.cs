using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkBeat.Models
{
    public class FacLabControler
    {
        public Models modelFact = new Models();

        public DataTable GetIdPersona(int idPersona)
        {
            return this.modelFact.GetIdPersona(idPersona);
        }
        public void InsertIdPersona(int idTenant,
        int idPersona,
        string nombre,
        string Puesto,
        string RFC,
        string CURP,
        string NumEmpleado,
        string RegistroPatronal,
        string apellidoPat,
        string apellidoMat,
        string fechaIngreso,
        decimal SalarioDiarioIntegrado,
        decimal SalarioDiario,
        string SGUID,
        string GUIDExpediente,
        string email,
        string pass,
        string failedAttempts,
        string blockedUntil)
        {
            this.modelFact.InsertIdPersona(idTenant,
        idPersona,
        nombre,
        Puesto,
        RFC,
        CURP,
        NumEmpleado,
        RegistroPatronal,
        apellidoPat,
        apellidoMat,
        fechaIngreso,
        SalarioDiarioIntegrado,
        SalarioDiario,
        SGUID,
        GUIDExpediente,
        email,
        pass,
        failedAttempts,
        blockedUntil);
        }
    }
}

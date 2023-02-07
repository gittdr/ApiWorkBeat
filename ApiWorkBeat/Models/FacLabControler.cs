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
        public void InsertRazonSocial(int idPersona,int idRazonSocial,string nombreR,string idEmpleado,int IdPuesto,int idPosicion)
        {
            this.modelFact.InsertRazonSocial(idPersona,idRazonSocial,nombreR,idEmpleado,IdPuesto,idPosicion);
        }

        public void InsertDatosNomina(int idEmpleado, int idRazonSocial, string RazonSocial, string rfcRazonSocial, string fechaBajaRazonSocial, int estatus, string numeroEmpleado)
        {
            this.modelFact.InsertDatosNomina(idEmpleado,idRazonSocial,RazonSocial,rfcRazonSocial,fechaBajaRazonSocial,estatus,numeroEmpleado);
        }
        public void InsertAtributoDefault(int idP, string nombreAtributo, string referencia, string nombreA)
        {
            this.modelFact.InsertAtributoDefault(idP, nombreAtributo, referencia, nombreA);
        }
        public void InsertPosiciones(int idEmpleado, int idP, string nombreP, string nombreOrganizacionP, string codigoP)
        {
            this.modelFact.InsertPosiciones(idEmpleado, idP, nombreP, nombreOrganizacionP, codigoP);
        }
        public void InsertMovimientosPersonal(int idEmpleado, string nombre, string apellidoPat, string apellidoMat, string fecha, string tipoMovimiento, string motivoBaja, int idCausaBajaIMSS, int causaBajaIMSS, string observaciones, string fechaBaja, string fechaCaptura, string fechaIngresoPosicion, string fechaIngresoOrganizacion)
        {
            this.modelFact.InsertMovimientosPersonal(idEmpleado, nombre, apellidoPat, apellidoMat, fecha, tipoMovimiento, motivoBaja, idCausaBajaIMSS, causaBajaIMSS, observaciones, fechaBaja, fechaCaptura, fechaIngresoPosicion, fechaIngresoOrganizacion);
        }
        public void UpdateDataMP()
        {
            this.modelFact.UpdateDataMP();
        }
    }
}

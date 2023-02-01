using ApiWorkBeat.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApiWorkBeat
{
    public class Program
    {
        public static FacLabControler facLabControler = new FacLabControler();
        static void Main(string[] args)
        {
            ObtenerToken();
        }
        public static void ObtenerToken()
        {
            var client = new RestClient("https://api.workbeat.com/oauth/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            string client_id = System.Web.Configuration.WebConfigurationManager.AppSettings["client_id"];
            string client_secret = System.Web.Configuration.WebConfigurationManager.AppSettings["client_secret"];
            string grant_type = System.Web.Configuration.WebConfigurationManager.AppSettings["grant_type"];
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", grant_type);
            request.AddParameter("client_id", client_id);
            request.AddParameter("client_secret", client_secret);
            IRestResponse response = client.Execute(request);

            dynamic resp = JObject.Parse(response.Content);
            string token = resp.access_token;
            Program obj = new Program();
            obj.GetEmpleadosActivos(token);

        }
        public void GetEmpleadosActivos(string token)
        {
            var client = new RestClient("https://api.workbeat.com/v2/adm/empleadosActivos");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            RestResponse response = (RestResponse) client.Execute(request);
            var objResponse1 =JsonConvert.DeserializeObject<List<GetInfo>>(response.Content);
            dynamic info = objResponse1;
            //int total = Enumerable.Count(info);
            //if (total > 6768)
            //{

            //}
            foreach (var item in info)
            {
                int idTenant = item.idTenant;
                int idPersona = item.idPersona;
                string nombre = item.nombre;
                string Puesto = item.Puesto;
                string RFC = item.RFC;
                string CURP = item.NumEmpleado;
                string NumEmpleado = item.NumEmpleado;
                string RegistroPatronal = item.RegistroPatronal;
                string apellidoPat = item.apellidoPat;
                string apellidoMat = item.apellidoMat;
                string fechaIngreso = item.fechaIngreso;
                decimal SalarioDiarioIntegrado = item.SalarioDiarioIntegrado;
                decimal SalarioDiario = item.SalarioDiario;
                string SGUID = item.GUID;
                string GUIDExpediente = item.GUIDExpediente;
                string email = item.email;
                string pass = item.password;
                string failedAttempts = item.failedAttempts;
                string blockedUntil = item.blockedUntil;

                //Aqui va el metodo para validar que no exista el idPersona
                DataTable rtds = facLabControler.GetIdPersona(idPersona);
                if (rtds.Rows.Count == 0)
                {
                    //Insertar idPersona
                    facLabControler.InsertIdPersona(idTenant,idPersona,nombre,Puesto,RFC,
                        CURP,NumEmpleado,RegistroPatronal,apellidoPat,apellidoMat,fechaIngreso,
                        SalarioDiarioIntegrado,SalarioDiario,SGUID,GUIDExpediente,email,pass,failedAttempts,blockedUntil);
                    GetRazonesSociales(token, idPersona);
                }
             }
        }
        public void GetRazonesSociales(string token,int idPersona)
        {
            string url1 = "https://api.workbeat.com/v2/adm/empleados/";
            string url2 = "/RazonesSociales";
            var client = new RestClient(url1+idPersona+url2);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            RestResponse response = (RestResponse)client.Execute(request);
            var objResponse1 = JsonConvert.DeserializeObject<List<RazonSocial>>(response.Content);
            dynamic info = objResponse1;
            foreach (var item in info)
            {
                int idRazonSocial = item.idRazonSocial;
                string nombreR = item.nombre;
                string idEmpleado = item.idEmpleado;
                int IdPuesto = item.IdPuesto;
                int idPosicion = item.idPosicion;

                facLabControler.InsertRazonSocial(idPersona,idRazonSocial,nombreR,idEmpleado,IdPuesto,idPosicion);

            }
        }
        public void GetMotivosBaja(string token)
        {
            var client = new RestClient("https://api.workbeat.com/v2/adm/empleadosActivos");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            RestResponse response = (RestResponse)client.Execute(request);
            var objResponse1 = JsonConvert.DeserializeObject<List<GetInfo>>(response.Content);
            dynamic info = objResponse1;
            foreach (var item in info)
            {
                int idTenant = item.idTenant;
                int idPersona = item.idPersona;
                string nombre = item.nombre;

            }
        }
    }
}

using ApiWorkBeat.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApiWorkBeat
{
    internal class Program
    {
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
            foreach (var item in info)
            {
                int idTenant = item.idTenant;
                int idPersona = item.idPersona;
                string nombre = item.nombre;

            }
        }
    }
}

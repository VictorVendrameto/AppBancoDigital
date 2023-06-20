using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace AppBancoDigital.Service
{
    public class DataService
    {
        private static readonly string server = "https//10.0.2.2:8000";

        protected static async Task<string> GetDataFromService(string rota) 
        {
            string json_response;

            string uri = server + rota;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
                throw new Exception("Conecte-se à Internet.");
            

            using (HttpClient client = new HttpClient()) 
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception(DecodeServerError(response.StatusCode));
                }
                    
            }
            return json_response;
        }
        protected static async Task<string> PostDataToService(string json_object, string rota) 
        {
            string json_response;

            string uri = server + rota;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet) 
            {
                throw new Exception("Conecte-se à Internet.");
            }
            using (HttpClient client = new HttpClient()) 
            {
                HttpResponseMessage response = await client.PostAsync(uri,
                    new StringContent(json_object, Encoding.UTF8, 
                    "application/json"));

                if(response.IsSuccessStatusCode) 
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
                else 
                {
                    throw new Exception(DecodeServerError(response.StatusCode));
                }

                return json_response;
            }

            private static string DecodeServerError(System.Net.HttpStatusCode status_code) 
            {
                string msg_error;

                switch (status_code) 
                {
                    case System.Net.HttpStatusCode.BadRequest:
                        msg_error = "A requisição não pode ser atendida agora. Tente mais tarde.";
                        break;

                    case System.Net.HttpStatusCode.NotFound:
                        msg_error = "Recurso indisponível no momento. Tente mais tarde.";
                        break;

                    case System.Net.HttpStatusCode.InternalServerError:
                        msg_error = "Nosso banco de dados está indisponível. Tente mais tarde.";
                        break;

                    case System.Net.HttpStatusCode.RequestTimeout:
                        msg_error = "O servidor está demorando muito para responder. Tente novamente.";
                        break;

                    case System.Net.HttpStatusCode.Forbidden:
                        msg_error = "Recurso temporariamente indisponível. Tente mais tarde.";
                        break;

                    default:
                        msg_error = "Estamos com dificuldades para acessar nosso servidor, tente novamente.";
                        break;
                }
                return msg_error;
            }
        }
    }
}

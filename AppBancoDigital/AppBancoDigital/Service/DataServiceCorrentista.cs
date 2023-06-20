using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using AppBancoDigital.Model;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<Correntista> AuthenticCorrentista(Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            Console.WriteLine("_____________________________________________");
            Console.WriteLine(json_to_send);
            Console.WriteLine("_____________________________________________");

            string json = await DataService.PostDataToService(json_to_send, "/correntista/login");


            if (json != "false")
                return null;

              Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);
            
            return correntista;
        }

        public static async Task <Correntista> SignOn (Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            Console.WriteLine("_____________________________________________");
            Console.WriteLine(json_to_send);
            Console.WriteLine("_____________________________________________");

            string json = await DataService.PostDataToService(json_to_send, "/correntista/save");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }
}

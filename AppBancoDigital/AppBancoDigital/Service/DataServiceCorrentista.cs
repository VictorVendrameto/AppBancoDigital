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
            string json = await DataService.PostDataToService(json_to_send, "/correntista/entrar");

            Correntista correntista = new Correntista();
            if (json != "false") 
            {
                correntista = JsonConvert.DeserializeObject<Correntista>(json);
            }
            return correntista;
        }

        public static async Task <Correntista> SignOn (Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_to_send, "/correntista/save");

            Console.WriteLine("_____________________________________________");
            Console.WriteLine(json);
            Console.WriteLine("_____________________________________________");

            Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);

            return correntista;
        }
    }
}

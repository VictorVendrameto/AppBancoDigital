using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Correntista
    {
        public int id { get; set; }

        public int cpf { get; set; }

        public string senha { get; set; }

        public DateTime data_nasc { get; set;}
    }
}

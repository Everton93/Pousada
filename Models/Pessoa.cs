using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
    }
}

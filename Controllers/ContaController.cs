using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ContaController
    {

        public static void adicionarConta(Conta conta)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Contas.Add(conta);
                ctx.SaveChanges();
            }
        }
    }
}

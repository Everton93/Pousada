using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ServicoController 
    {
        public static void adicionarServico(Servicos servico)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Servicos.Add(servico);
                ctx.SaveChanges();
            }
        }
        /* public Servicos detalhesServico(int id, Servicos detalheServico)
          {
              using (Contexto ctx = new Contexto())
              {
                  if (id != null)
                  {

                  }
              }
          }*/
        private static Servicos buscarServico(int id, Contexto ctx)
        {
            return ctx.Servicos.Find(id);
        }
        public static void editarServico(int id, Servicos servicoNovo)
        {
            using (Contexto ctx = new Contexto())
            {
                Servicos servAntigo = buscarServico(id, ctx);

                if (servAntigo != null)
                {
                    servAntigo.nomeServico = servicoNovo.nomeServico;
                    servAntigo.valor = servicoNovo.valor;
                    servAntigo.descricao = servicoNovo.descricao;
                    ctx.Entry(servAntigo).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void excluir(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Servicos serv = buscarServico(id, ctx);

                if (serv != null)
                {
                    ctx.Entry(serv).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
        public static List<Servicos> listarServicos()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Servicos.ToList();

            }
        }
    }

}

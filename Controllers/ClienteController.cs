using Models;
using Models.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {

        public static void adicionarCliente(Cliente hospede)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Clientes.Add(hospede);
                ctx.SaveChanges();
            }
        }

        private static Cliente buscarCliente(int id, Contexto ctx)
        {
            return ctx.Clientes.Find(id);
        }

        public static Cliente detalhes(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return buscarCliente(id, ctx);
            }
        }
        public static void editarCliente(int id, Cliente novosDados)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente hospededeDadosAntigos = buscarCliente(id, ctx);
                if (hospededeDadosAntigos != null)
                {
                    hospededeDadosAntigos.nome = novosDados.nome;
                    hospededeDadosAntigos.idade = novosDados.idade;
                    hospededeDadosAntigos.cpf = novosDados.cpf;
                    hospededeDadosAntigos.rg = novosDados.rg;
                    hospededeDadosAntigos.telefone = novosDados.telefone;
                    hospededeDadosAntigos.endereco = novosDados.endereco;
                    ctx.Entry(hospededeDadosAntigos).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void excluir(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente hosp = buscarCliente(id, ctx);

                if (hosp != null)
                {
                    ctx.Entry(hosp).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }

        public static List<Cliente> listaCliente()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Clientes.ToList();
            }
        }
    }
}
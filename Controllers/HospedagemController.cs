using Models;
using Models.DAL;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class HospedagemController 
    {
        public static void adicionarHospede(Hospedagem hospede)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Hospedagens.Add(hospede);
                ctx.SaveChanges();
            }
        }
        private static Hospedagem buscarHospedagem(int id, Contexto ctx)
        {
            return ctx.Hospedagens.Find(id);
        }

        public static Hospedagem detalhes(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return buscarHospedagem(id,ctx );

            }
        }

        public static void editarHospedagem(int id, Hospedagem hospedagemNova)
        {
            using (Contexto ctx = new Contexto())
            {
                Hospedagem hospedagemAntiga = buscarHospedagem(id, ctx);

                if (hospedagemAntiga != null)
                {
                    hospedagemAntiga.quarto = hospedagemNova.quarto;
                    hospedagemAntiga.numPessoas = hospedagemNova.numPessoas;
                    ctx.Entry(hospedagemAntiga).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void excluir(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Hospedagem hospe = buscarHospedagem(id, ctx);

                if (hospe != null)
                {
                    ctx.Entry(hospe).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
        public static List<Hospedagem> listarHospedagem()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Hospedagens.ToList();
            }
        }
    }

}

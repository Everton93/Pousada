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
    public class ReservaController
    {
        public static void adicionarReserva(Reserva reserva)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Reservas.Add(reserva);
                ctx.SaveChanges();
            }
        }

        private static Reserva buscarReserva(int id, Contexto ctx)
        {
            return ctx.Reservas.Find(id);
        }



        public static void editarReserva(int id, Reserva reservaAtualizada)
        {
            using (Contexto ctx = new Contexto())
            {
                Reserva reservaAntiga = buscarReserva(id, ctx);
                if (reservaAntiga != null)
                {
                    reservaAntiga.dataEntrada = reservaAtualizada.dataEntrada;
                    reservaAntiga.dataSaida = reservaAtualizada.dataSaida;
                    reservaAntiga.tipoQuarto = reservaAtualizada.tipoQuarto;
                    ctx.Entry(reservaAntiga).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void excluir(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Reserva res = buscarReserva(id, ctx);

                if (res != null)
                {
                    ctx.Entry(res).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }

        public static List<Reserva> listarReservas()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Reservas.ToList();

            }
        }
    }

}

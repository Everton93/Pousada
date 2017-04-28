using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            Database.SetInitializer<Contexto>(
                //new DropCreateDatabaseAlways<Contexto>()
                new DropCreateDatabaseIfModelChanges<Contexto>()
                );
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Hospedagem> Hospedagens { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Conta> Contas { get; set; }

      

    }
}

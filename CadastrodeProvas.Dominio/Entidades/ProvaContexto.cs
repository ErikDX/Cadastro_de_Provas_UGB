using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CadastrodeProvas.Dominio.Entidades
{
    public class ProvaContexto : DbContext
    {
        public ProvaContexto()
           : base("nome=ConexaoCadastro")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProvaContexto>(new CreateDatabaseIfNotExists<ProvaContexto>());
        }
        public DbSet<Prova> Prova { get; set; }
    }
}

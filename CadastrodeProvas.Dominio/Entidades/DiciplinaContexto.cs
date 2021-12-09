using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CadastrodeProvas.Dominio.Entidades
{
    public class DiciplinaContexto : DbContext
    {
        public DiciplinaContexto()
            : base("nome=ConexaoCadastro")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DiciplinaContexto>(new CreateDatabaseIfNotExists<DiciplinaContexto>());
        }
        public DbSet<Diciplina> Diciplina { get; set; }
        public object diciplina { get; internal set; }
    }
}

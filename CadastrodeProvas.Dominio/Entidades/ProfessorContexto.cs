using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CadastrodeProvas.Dominio.Entidades
{
    public class ProfessorContexto : DbContext
    {
        public ProfessorContexto()
            : base("nome=ConexaoCadastro")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProfessorContexto>(new CreateDatabaseIfNotExists<ProfessorContexto>());
        }
        public DbSet<Professor> Professores { get; set; }
    }
}

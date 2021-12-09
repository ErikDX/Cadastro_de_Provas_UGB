using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastrodeProvas.Dominio.Entidades
{
    [Table("Professores")]
    public class Professor
    {
        public string matricula_professor { get; set; }
        [Required(ErrorMessage = "Por favor, informe a matricula do Professor")]
        public string nome_professor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastrodeProvas.Dominio.Entidades
{
    [Table("diciplina")]
    public class Diciplina
    {
        public int id_diciplina { get; set; }
        [Required(ErrorMessage = "ID da diciplina necessario")]
        public string nome_diciplina { get; set; }
        [Required]
        public string curso_diciplina { get; set; }
    }
}

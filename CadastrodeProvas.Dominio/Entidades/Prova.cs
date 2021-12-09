using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastrodeProvas.Dominio.Entidades
{
    [Table("Prova")]
    public class Prova
    {
        public int id_prova { get; set; }
        [Required(ErrorMessage = "ID da prova necessario")]
        public DateTime data_prova { get; set; }
        [Required(ErrorMessage = "Por favor, informe a data da prova")]
        public DateTime prazo_inicial { get; set; }
        public DateTime prazo_final { get; set; }
        public DateTime data_entrega { get; set; }
        public int id_diciplina { get; set; }
        public string matricula_professor { get; set; }
        [Required(ErrorMessage = "Por favor, informe a matricula do Professor")]
        public string status { get; set; }
        [Required(ErrorMessage = "Status da prova necessario")]
        public byte[] prova { get; set; }
    }
}

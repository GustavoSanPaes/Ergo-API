using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErgoAPI.Data.Dtos
{
    public class ReadTarefaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Anote o Compromisso")]
        public string Compromisso { get; set; }

        [Required(ErrorMessage = "Descreva o Status da Tarefa")]
        public string Status { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}

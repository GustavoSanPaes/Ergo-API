using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErgoAPI.Data.Dtos
{
    public class UpdateTarefaDto
    {
        [Required(ErrorMessage = "Anote o Compromisso")]
        public string Compromisso { get; set; }

        [Required(ErrorMessage = "Descreva o Status da Tarefa")]
        public string Status { get; set; }
    }
}


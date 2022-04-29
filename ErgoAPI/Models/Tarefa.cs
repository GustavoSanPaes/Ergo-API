using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErgoAPI.Models
{
    public class Tarefa
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Anote o Compromisso")]
        public string Compromisso { get; set; }

        [Required(ErrorMessage ="Descreva o Status da Tarefa")]
        public bool Status { get; set; }
    }
}

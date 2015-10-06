using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfsCursoMtoM_WithPayload.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
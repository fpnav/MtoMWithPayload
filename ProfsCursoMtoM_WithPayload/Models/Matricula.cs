using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfsCursoMtoM_WithPayload.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int CursoId { get; set; }
        public int ProfessorId { get; set; }
        public Decimal Nota { get; set; }


        public virtual Curso Curso { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
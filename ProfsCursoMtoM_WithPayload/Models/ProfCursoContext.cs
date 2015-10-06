using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProfsCursoMtoM_WithPayload.Models
{
    public class ProfCursoContext : DbContext
    {
        public ProfCursoContext() : base("ProfCursoConnection")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

    }
}
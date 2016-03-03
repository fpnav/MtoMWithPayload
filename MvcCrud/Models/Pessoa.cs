using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
    }
}
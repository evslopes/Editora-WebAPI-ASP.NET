    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Editora.Domain
{
    public class Autor
    {
        public int Id { get; set; }
        
        
        public String Nome { get; set; }

        
        public String UltimoNome { get; set; }

       
        public String Email { get; set; }

        
        public DateTime DataNascimento { get; set; }

        
        public virtual IList<Livro> Livros { get; set; }
    }
}

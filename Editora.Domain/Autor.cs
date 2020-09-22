using System;
using System.Collections.Generic;
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
        public List<Livro> Livros { get; set; }
    }
}

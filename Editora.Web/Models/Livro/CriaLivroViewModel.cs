using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Editora.Web.Models.Autor;

namespace Editora.Web.Models.Livro
{
    public class CriaLivroViewModel
    {
        public string Titulo { get; set; }


        public string ISBN { get; set; }


        public int Ano { get; set; }


        public List<AutorViewModel> Autors { get; set; }

        public int AutorId { get; set; }
    }
}

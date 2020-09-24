using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Editora.Domain
{
    public class Livro
    {
        public int Id { get; set; }
     
        public String Titulo { get; set; }
        
        public String ISBN { get; set; }

        public int Ano { get; set; }


        public int AutorId { get; set; }

        [JsonIgnore]
        public virtual Autor Autor { get; set; }

    }
}

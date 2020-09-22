using System;
using System.Collections.Generic;
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

        [JsonIgnore]
        public Autor Autor { get; set; }

        public int AutorId { get; set; }

    }
}

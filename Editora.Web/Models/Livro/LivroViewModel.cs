using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Editora.Web.Models.Autor;

namespace Editora.Web.Models.Livro
{
    public class LivroViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigado, favor preencher")]
        [StringLength(250)]
        [DisplayName("Título do Livro:")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O ISBN é obrigado, favor preencher")]
        [StringLength(250)]
        [DisplayName("ISBN:")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "O ano é obrigado, favor preencher")]
        [StringLength(4)]
        [DisplayName("Ano de publicação: ")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Campo Autor é obrigatório")]
        public AutorViewModel Autor { get; set; }

        public int AutorId { get; set; }
    }
}

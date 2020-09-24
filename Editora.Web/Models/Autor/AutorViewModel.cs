using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Editora.Web.Models.Livro;

namespace Editora.Web.Models.Autor
{
    public class AutorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigado, favor preencher")]
        [StringLength(250)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório, favor preencher")]
        [StringLength(250)]
        [DisplayName("Sobrenome")]
        public string UltimoNome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório, favor preencher")]
        [DisplayName("Endereço de Email")]
        [StringLength(250)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória, favor preencher")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Livros")]
        public virtual IList<LivroViewModel> Livros { get; set; }
    }
}

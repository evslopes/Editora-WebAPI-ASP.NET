using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Editora.Domain
{
    public class Usuario
    {
        public int Id { get; set; }

        [DisplayName("Login ou Username: ")]
        public String Login { get; set; }

        [StringLength(255, ErrorMessage = "Sua senha precisa ter entre 5 e 255 caracteres", MinimumLength = 5)]
        [DisplayName("Password: ")]
        public String Password { get; set; }

    }
}

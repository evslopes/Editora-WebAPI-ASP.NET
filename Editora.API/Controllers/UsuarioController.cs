using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Editora.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Editora.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService UsuarioService { get; set; }

        public UsuarioController(UsuarioService usuarioService)
        {
            this.UsuarioService = usuarioService;

        }


        [Route("Token")]
        [HttpPost]
        [RequireHttps]
        public IActionResult Token([FromBody] LoginRequest loginRequest)
        {
            var token = this.UsuarioService.Login(loginRequest.Login, loginRequest.Senha);

            if (String.IsNullOrWhiteSpace(token))
            {
                return BadRequest("Login ou senha invalida");
            }

            return Ok(new
            {
                Token = token
            });
        }

    }

    public class LoginRequest
    {
        public String Login { get; set; }
        public String Senha { get; set; }

    }
}

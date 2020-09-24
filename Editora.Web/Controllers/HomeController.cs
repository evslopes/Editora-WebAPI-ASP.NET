using System.Diagnostics;
using System.Linq;
using Editora.Service;
using Editora.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutorServices autorServices;
        private readonly LivroServices livroServices;

        public HomeController(ILogger<HomeController> logger, AutorServices services, LivroServices services2)
        {
            _logger = logger;
            this.autorServices = services;
            this.livroServices = services2;
        }

        public ActionResult Index()
        {
            var paginaInicial = new PaginaInicialViewModel();

            var autors = autorServices.GetAll();
            paginaInicial.QuantidadeDeAutors = autors.Count;

            var livros = livroServices.GetAll();
            paginaInicial.QuantidadeDeLivros = livros.Count;

            return View(paginaInicial);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

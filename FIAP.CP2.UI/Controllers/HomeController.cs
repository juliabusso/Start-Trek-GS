using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FIAP.CP2.UI.Models;

namespace FIAP.CP2.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Página inicial do projeto
        public IActionResult Index()
        {
            // Aqui você poderia enviar dados para a Home futuramente, se quiser
            ViewData["Titulo"] = "Projeto Star Trek - Profissões no Tempo";
            ViewData["Descricao"] =
                "Explore como as profissões evoluíram ao longo da história, " +
                "como elas existem hoje e como podem se transformar no futuro. " +
                "Este projeto ajuda a entender o impacto da tecnologia e das mudanças sociais " +
                "no mercado de trabalho — inspirado no universo futurista de Star Trek.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

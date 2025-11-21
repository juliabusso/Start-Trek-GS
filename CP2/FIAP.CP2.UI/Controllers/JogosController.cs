using FIAP.CP2.Business;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.CP2.UI.Controllers
{
    public class JogosController : Controller
    {
        private readonly BibliotecaJogos _biblioteca;

        public JogosController()
        {
            _biblioteca = new BibliotecaJogos();
        }

        public IActionResult Index()
        {
            var jogos = _biblioteca.ListarTodos(); 
            return View(jogos);
        }
    }
}


        // Sample method: listar jogos por profissão (usando seed)
        public IActionResult ByProfissao(string profissaoId)
        {
            var jogos = BibliotecaJogos_Extended.GetJogosSeed();
            var list = jogos.FindAll(j => j.TemaProfissaoId == profissaoId);
            return View("Index", list);
        }

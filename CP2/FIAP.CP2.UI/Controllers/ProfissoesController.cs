using Microsoft.AspNetCore.Mvc;
using FIAP.CP2.Model;
using System.Linq;
using System.Collections.Generic;
using Fiap.CP2.Business;

namespace FIAP.CP2.UI.Controllers
{
    public class ProfissoesController : Controller
    {
        // For the sample, use in-memory seed from BibliotecaJogos_Extended
        private List<ProfissaoModel> _profissoes = BibliotecaJogos_Extended.GetProfissoesSeed();

        public IActionResult Index()
        {
            return View(_profissoes);
        }

        public IActionResult Details(string id)
        {
            var p = _profissoes.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProfissaoModel model)
        {
            if (!ModelState.IsValid) return View(model);
            // In production, persist to DB
            model.Id = System.Guid.NewGuid().ToString();
            _profissoes.Add(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var p = _profissoes.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(ProfissaoModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var existing = _profissoes.FirstOrDefault(x => x.Id == model.Id);
            if (existing != null)
            {
                existing.Nome = model.Nome;
                existing.Status = model.Status;
                existing.Descricao = model.Descricao;
                existing.TecnologiasRelacionadas = model.TecnologiasRelacionadas;
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(string id)
        {
            var p = _profissoes.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            var p = _profissoes.FirstOrDefault(x => x.Id == id);
            if (p != null) _profissoes.Remove(p);
            return RedirectToAction(nameof(Index));
        }
    }
}

using FIAP.CP2.Business;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.CP2.Controllers
{
    public class TiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

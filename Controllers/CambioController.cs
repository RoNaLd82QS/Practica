using Microsoft.AspNetCore.Mvc;
using CasaDeCambioOnline.Models;

namespace CasaDeCambioOnline.Controllers
{
    public class CambioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CambioViewModel model)
        {
            if (model.MonedaOrigen == "BRL" && model.MonedaDestino == "PEN")
            {
                model.TasaCambio = 0.74m; // Puedes usar una API en producción
            }

            return RedirectToAction("Boleta", model);
        }

        [HttpGet]
        public IActionResult Boleta(CambioViewModel model)
        {
            return View(model);
        }
    }
}

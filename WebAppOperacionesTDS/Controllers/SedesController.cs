using Microsoft.AspNetCore.Mvc;
using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Controllers
{
    public class SedesController : Controller
    {
        private List<Sedes>getSedes()
        {
            var InfSedes=new List<Sedes>();
            InfSedes.Add(new Sedes
            {
                IdSedes = 001,
                Nombre = "Pisco",
                Direccion = "Av. Las camelias N° 123",
                Responsable = "Juan Carlos Arenas Quispe"

            });
            InfSedes.Add(new Sedes
            {
                IdSedes=002,
                Nombre="Barranca",
                Direccion="Av. Los Olivos N° 145",
                Responsable="Juan Carlos Arenas Quispe"
            });
            InfSedes.Add(new Sedes
            {
                IdSedes=003,
                Nombre="Trujillo",
                Direccion="Av. Los Pinos N°148",
                Responsable="Luis Carlos Torres Lara"
            });
            return InfSedes;
        }
        public IActionResult VBIndex()
        {
            var model = getSedes();
            ViewBag.Informacion = model;
            return View();
        }
        public IActionResult TDIndex()
        {
            var tdmodel=getSedes();
            TempData["Informacion"] = tdmodel;
            return View();  
        }
    }
}

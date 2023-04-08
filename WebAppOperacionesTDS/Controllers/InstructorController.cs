using Microsoft.AspNetCore.Mvc;
using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Controllers
{
    public class InstructorController : Controller
    {
        public List<Instructor>GetInstructor()
        {
            var RegistrosInstructor = new List<Instructor>();
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor=1,
                Nombres="Juan Carlos",
                Apellidos="Torres Garcia",
                DNI=42563658,
                EDAD=35,
                Especialidad="Ingeniero de Sistemas",
                Estado="Activo"
                
            });
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor = 2,
                Nombres = "Maria Alejandra",
                Apellidos = "Garcia Garcia",
                DNI = 42587854,
                EDAD = 36,
                Especialidad = "Ingeniero Informatico",
                Estado="Activo"
            });
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor = 3,
                Nombres = "Carlos Andres",
                Apellidos = "De La Cruz Garcia",
                DNI = 42569878,
                EDAD = 35,
                Especialidad = "Ingeniero Civil",
                Estado="Activo"
            });
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor = 4,
                Nombres = "Luis Andres",
                Apellidos = "Melgarejo Zorrilla",
                DNI = 47856987,
                EDAD = 47,
                Especialidad = "Ingeniero Mecanico",
                Estado="Activo"
            });
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor = 5,
                Nombres = "Luis Angel",
                Apellidos = "Ipanaque Choquehuanca",
                DNI = 42578965,
                EDAD = 25,
                Especialidad = "Ingenierio Electrico",
                Estado="Inactivo"
            });
            RegistrosInstructor.Add(new Instructor
            {
                IdInstructor = 6,
                Nombres = "Carlos Jose",
                Apellidos = "Alberca Torres",
                DNI = 42569875,
                EDAD = 45,
                Especialidad = "Ingenierio Mecanico",
                Estado="Inactivo"
            });
            return RegistrosInstructor;

        }

        public IActionResult Index()
        {
            var modelo = GetInstructor();
            return View(modelo);
        }
        public IActionResult VDIndex()
        {
            ViewData["Id"] = "Id";
            ViewData["No"] = "Nombres";
            ViewData["Ap"] = "Apellidos";
            ViewData["Dn"] = "Dni";
            ViewData["Ed"] = "Edad";
            ViewData["Es"] = "Especialidad";
            ViewData["Est"] = "Estado";

            var VDModel=GetInstructor();
            ViewData["Registros"] = VDModel;
            return View();
        }
    }
}

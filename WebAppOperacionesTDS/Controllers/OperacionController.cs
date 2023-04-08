using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebAppOperacionesTDS.Data.DataAccess;
using WebAppOperacionesTDS.Data.Interface;
using WebAppOperacionesTDS.Models;
using X.PagedList;

namespace WebAppOperacionesTDS.Controllers
{
    [Authorize]
    public class OperacionController : Controller
    {
        public readonly IDAOperacion DAOperacion;
        public readonly IDACliente DACliente;
        public readonly IDALugar DALugar;
        public readonly IDAServicios DAServicios;
        private ServiceBancosReference.ServiceBancosClient service=new 
            ServiceBancosReference.ServiceBancosClient();

        public IActionResult ServiceIndex() 
        {
            ViewBag.CuentasServicio = service.GetCuentasAsync().Result;
            return View();
        }

        public OperacionController(IDAOperacion DAOperacion, IDACliente DACliente, IDALugar DALugar, IDAServicios DAServicios)
           
        {
            this.DAOperacion = DAOperacion;
            this.DACliente = DACliente;
            this.DALugar = DALugar;
            this.DAServicios = DAServicios;
        }


        //[Route("WebAppOpe")]
        public IActionResult Index(int page=1)
        {
            //var model = new DAOperacion();
            var pageNumber = page;
            var informacionDB = DAOperacion.GetOperacion();
            var Datos = informacionDB.OrderByDescending(x => x.IdOperacion).ToList().ToPagedList(pageNumber, 8);
            return View(Datos);
        }
        public IActionResult Create()
        {
            //var lugar=new DALugar();
            ViewBag.Lugar = DALugar.GetLugar();
            //var servicio = new DAServicios();
            ViewBag.Servicio = DAServicios.GetServicio();

            //var cliente=new DACliente();
            ViewBag.Cliente = DACliente.GetCliente();
            return View();
    }
        [HttpPost]
        public IActionResult Create(Operacion operacion)
        {
            operacion.IdOperacion = 0;
            operacion.FechaRegistro = DateTime.Now;
            //var modelinsert = new DAOperacion();
            var model = DAOperacion.InsertOperaciones(operacion);
            if (model>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    public IActionResult Details(int id)
        {
            //var detOperacion = new DAOperacion();
            var modelodetalle = DAOperacion.GetIdOperacion(id);
            return View(modelodetalle);
        }
    public IActionResult Edit(int id)
            {
           // var Lugar = new DALugar();
            ViewBag.Lugar = DALugar.GetLugar();
             
            //var Cliente= new DACliente();
            ViewBag.Cliente=DACliente.GetCliente();

            //var Servicio = new DAServicios();
            ViewBag.Servicio= DAServicios.GetServicio();

            //var Operacion = new DAOperacion();
            var model = DAOperacion.GetIdOperacion(id);
            return View(model);
            }
        [HttpPost]
        public IActionResult Edit(Operacion operacion) {
            operacion.FechaModificacion = DateTime.Now;
           // var model = new DAOperacion();
            var resultado = DAOperacion.UpdateOperacion(operacion);
            if(resultado)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(resultado); 
            }
        }
       public IActionResult Delete(int id)
        {
            //var OperacionDelete = new DAOperacion();
            var resultado=DAOperacion.DeleteOperacion(id);
            return RedirectToAction("Index");
        }
        }
}


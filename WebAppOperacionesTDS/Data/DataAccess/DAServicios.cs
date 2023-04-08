using WebAppOperacionesTDS.Data.Interface;
using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.DataAccess
{
    public class DAServicios:IDAServicios
    {
        public IEnumerable<Servicio>GetServicio()
        {
            var listadoservicio = new List<Servicio>();
            using(var db=new ApplicationDbContext())
            {
                listadoservicio = db.Servicio.ToList();

            }
            return listadoservicio;
        }
    }
}

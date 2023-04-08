using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.Interface
{
    public interface IDAServicios
    {
        IEnumerable<Servicio> GetServicio();
    }
}

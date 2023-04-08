using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.Interface
{
    public interface IDALugar
    {
        IEnumerable<Lugar> GetLugar();

    }
}

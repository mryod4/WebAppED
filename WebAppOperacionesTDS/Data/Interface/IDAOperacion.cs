using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.Interface
{
    public interface IDAOperacion
    {
        IEnumerable<Operacion> GetOperacion();
        int InsertOperaciones(Operacion operacion);
        Operacion GetIdOperacion(int id);
        Boolean UpdateOperacion(Operacion operacion);
        Boolean DeleteOperacion(int id);

    }
}

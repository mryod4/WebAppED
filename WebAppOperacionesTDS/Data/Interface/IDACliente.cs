using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.Interface
{
    public interface IDACliente
    {
        IEnumerable<Cliente> GetCliente();

    }
}

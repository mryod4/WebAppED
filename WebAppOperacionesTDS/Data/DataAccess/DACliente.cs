using WebAppOperacionesTDS.Data.Interface;
using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.DataAccess
{
    public class DACliente:IDACliente
    {
        public IEnumerable<Cliente>GetCliente()
        {
            var listadocliente=new List<Cliente>(); 
            using(var db=new ApplicationDbContext())
            {
                listadocliente=db.Cliente.ToList(); 
            }
            return listadocliente;
        }
    }
}

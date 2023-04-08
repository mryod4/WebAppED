using WebAppOperacionesTDS.Data.Interface;
using WebAppOperacionesTDS.Models;

namespace WebAppOperacionesTDS.Data.DataAccess;
    public class DALugar:IDALugar
    {
        public IEnumerable<Lugar>GetLugar()
    {
        var listado=new List<Lugar>();
        using (var db = new ApplicationDbContext())
        {
            listado = db.Lugar.ToList();
        }
        return listado;
    }
    }


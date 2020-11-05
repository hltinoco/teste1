using Microsoft.EntityFrameworkCore;
using YClient_htinoco2.Models;

namespace YClient_htinoco2
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext contexto;

            public DataService(ApplicationContext contexto)
            {
                this.contexto = contexto;
            }

            public void InicializaDB()
            {
                contexto.Database.Migrate();
            }
        }
    }
}

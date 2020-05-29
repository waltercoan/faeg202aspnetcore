using System.Collections.Generic;
using System.Threading.Tasks;
using faegtodo.Db;
using faegtodo.Models;

namespace faegtodo.Services
{
    public class ClientService : IClientService
    {
        private AppDbContext context;
        
        public ClientService(AppDbContext context){
            this.context = context;
        }

        public Task<IList<Client>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
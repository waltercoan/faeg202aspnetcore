using System.Collections.Generic;
using System.Threading.Tasks;
using faegtodo.Db;
using faegtodo.Models;
using Microsoft.EntityFrameworkCore;

namespace faegtodo.Services
{
    public class ClientService : IClientService
    {
        private AppDbContext context;
        
        public ClientService(AppDbContext context){
            this.context = context;
        }

        public async Task<IList<Client>> GetAll()
        {
            return await context.Clients.ToArrayAsync();
        }
    }
}
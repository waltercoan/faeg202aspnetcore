using System.Collections.Generic;
using System.Threading.Tasks;
using faegtodo.Models;

namespace faegtodo.Services
{
    public interface IClientService{
        Task<IList<Client>> GetAll();
        void Save(Client client);
    }
    
}
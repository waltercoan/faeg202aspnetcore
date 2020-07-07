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

        public void Delete(int id)
        {
            var customer = new Client(){
                Id = id
            };

            context.Clients.Remove(customer);
            context.SaveChanges();
        }

        public async Task<IList<Client>> GetAll()
        {
            return await context.Clients.ToArrayAsync();
        }

        public async Task<Client> GetById(int Id)
        {
            //ENTRADA => CORPO DA FUNCAO
            //client => client.Id == Id
            //select top 1 * from Client where Id = ? 
            return await context.Clients.FirstAsync(c => c.Id == Id);
        }

        public void Save(Client client)
        {
            if(client.Id == 0){
                context.Clients.Add(client);
            }else{
                context.Entry(client).State = EntityState.Modified;
            }
            
            context.SaveChanges();
        }
    }
}
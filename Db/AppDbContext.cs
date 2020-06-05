
using System;
using System.Collections.Generic;
using faegtodo.Models;
using Microsoft.EntityFrameworkCore;

namespace faegtodo.Db
{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            List<Client> listaClient = new List<Client>();

            listaClient.Add(new Client()
            {
                Id = 1,
                Name = "Zezinho",
                Address = "Rua lalalal 1000",
                Birthday = DateTime.Now
            });
            listaClient.Add(new Client()
            {
                Id = 2,
                Name = "Huguinho",
                Address = "Rua lulull 200",
                Birthday = DateTime.Now
            });

            modelBuilder.Entity<Client>().HasData(listaClient.ToArray());
        }

        public virtual DbSet<Client> Clients {get;set;}
    }
}
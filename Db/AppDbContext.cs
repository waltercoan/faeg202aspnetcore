
using System;
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
            modelBuilder.Entity<Client>().HasData(new Client()
            {
                Id = 1,
                Name = "Zezinho",
                Address = "Rua lalalal 1000",
                Birthday = DateTime.Now
            });
        }

        public virtual DbSet<Client> Clients {get;set;}
    }
}
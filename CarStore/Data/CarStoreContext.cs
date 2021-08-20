using CarStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Data
{
    public class CarStoreContext : IdentityDbContext
    {
        public CarStoreContext(DbContextOptions<CarStoreContext> option) : base(option)
        { 

        }

        public DbSet<Carro> Carro { get; set; }
        public DbSet<TesteDrive> TesteDrive { get; set; }
        public DbSet<Loja> Loja { get; set; }
    }
}

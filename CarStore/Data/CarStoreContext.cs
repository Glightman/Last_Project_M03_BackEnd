using CarStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Data
{
    public class CarStoreContext : DbContext
    {
        public CarStoreContext(DbContextOptions<CarStoreContext> option) : base(option)
        { 

        }

        public DbSet<Carro> Carro { get; set; }
    }
}

using CarStore.Data;
using CarStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public class TesteDriveSqlService : ITesteDriveService
    {
        CarStoreContext context;
        public TesteDriveSqlService(CarStoreContext context)
        {
            this.context = context;
        }
        public List<TesteDrive> getAll()
        {
            return context.TesteDrive.Include(t => t.carro).ToList();
        }
        public bool create(TesteDrive teste)
        {

            try
            {
                context.TesteDrive.Add(teste);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public TesteDrive get(int? id)
        {
            return context.TesteDrive.Include(t => t.carro).FirstOrDefault(c => c.id == id);
        }
        public bool update(TesteDrive t)
        {
            try
            {
                context.TesteDrive.Update(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int? id)
        {
            try
            {
                context.TesteDrive.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}

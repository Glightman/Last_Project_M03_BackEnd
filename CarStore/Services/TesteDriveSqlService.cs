using CarStore.Data;
using CarStore.Models;
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
            return context.TesteDrive.ToList();
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
            return context.TesteDrive.Find(id);
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

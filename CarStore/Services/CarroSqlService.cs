using CarStore.Data;
using CarStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public class CarroSqlService : ICarroService
    {
        CarStoreContext context;
        public CarroSqlService(CarStoreContext context)
        {
            this.context = context;
        }
        public List<Carro> getAll(string busca = null, bool ord = false)
        {
            List<Carro> lista = context.Carro.Include(c => c.testes).ToList();
            if (busca != null)
            {
                return lista.FindAll(a =>
                    a.marca.ToLower().Contains(busca.ToLower())
                );
            }
            if (ord)
            {
                lista = lista.OrderBy(c => c.marca).ToList();
                return lista;
            }
            return lista;
        }
        public bool create(Carro carro)
        {

            try
            {
                context.Carro.Add(carro);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Carro get(int? id)
        {
            return context.Carro.Include(c => c.testes).FirstOrDefault(c => c.id == id);
        }
        public bool update(Carro c)
        {
            try
            {
                context.Carro.Update(c);
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
                context.Carro.Remove(get(id));
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

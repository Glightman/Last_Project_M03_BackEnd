using CarStore.Data;
using CarStore.Models;
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
            List<Carro> lista = context.Carro.ToList();
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
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Carro get(int id)
        {
            return new();
        }
        public bool update(Carro c)
        {
            return false;
        }
        public bool delete(int id)
        {
            return false;
        }
    }
}

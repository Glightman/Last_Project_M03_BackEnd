using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public interface ICarroService
    {
        bool create(Carro carro);
        bool delete(int id);
        Carro get(int id);
        List<Carro> getAll(string busca = null, bool ord = false);
        bool update(Carro c);
    }
}

using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.DataAccess.Implementations
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public PizzaRepository()
        {

        }
        public void DeleteById(int id)
        {
            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            StaticDb.Pizzas.Remove(pizzaDb);
        }
        public List<Pizza> GetAll()
        {
            return StaticDb.Pizzas;
        }
        public Pizza GetById(int id)
        {
            return StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(Pizza entity)
        {
            entity.Id = ++StaticDb.OrderId;
            StaticDb.Pizzas.Add(entity);
            return entity.Id;
        }
        public void Update(Pizza entity)
        {
            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == entity.Id);
            int index = StaticDb.Pizzas.IndexOf(pizzaDb);
            StaticDb.Pizzas[index] = entity;
        }
    }
}

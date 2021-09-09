using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Shared.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.EFImplementations
{
    public class PizzaEFRepository : IPizzaRepository
    {
        private PizzaAppDbContext _pizzaAppDbContext;
        public PizzaEFRepository(PizzaAppDbContext pizzaAppDbContext)
        {
            _pizzaAppDbContext = pizzaAppDbContext;
        }
        public void DeleteById(int id)
        {
            Pizza pizzaDb = _pizzaAppDbContext.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizzaDb == null)
            {
                throw new ResourceNotFoundException($"The pizza with id {id} was not found!");
            }
            _pizzaAppDbContext.Pizzas.Remove(pizzaDb); 
            _pizzaAppDbContext.SaveChanges();
        }

        public List<Pizza> GetAll()
        {
            //select * from pizzas
            // return _pizzaAppDbContext.Pizzas.ToList();
            return _pizzaAppDbContext.Pizzas
                    .Include(x => x.PizzaOrders)
                    .ThenInclude(x => x.Order)
                    .ToList();
        }

        public Pizza GetById(int id)
        {
            //select top (1) * from Pizzas
            // where Id = 2
            // return _pizzaAppDbContext.Pizzas.FirstOrDefault(x => x.Id == id);
            return _pizzaAppDbContext.Pizzas
                   .Include(x => x.PizzaOrders)
                   .ThenInclude(x => x.Order)
                   .FirstOrDefault(x => x.Id == id);
        }

        public Pizza GetPizzaOnPromotion()
        {
            return _pizzaAppDbContext.Pizzas.FirstOrDefault(x => x.IsOnPromotion == true);
        }

        public int Insert(Pizza entity)
        {

            _pizzaAppDbContext.Pizzas.Add(entity); 
            return _pizzaAppDbContext.SaveChanges();
        }

        public void Update(Pizza entity)
        {
            _pizzaAppDbContext.Pizzas.Update(entity); 
            _pizzaAppDbContext.SaveChanges();
        }
    }
}

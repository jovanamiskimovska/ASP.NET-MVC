using Microsoft.EntityFrameworkCore.Internal;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.EFImplementations
{
    public class FeedbackEFRepository : IRepository<Feedback>
    {
        private PizzaAppDbContext _pizzaAppDbContext;
        public FeedbackEFRepository(PizzaAppDbContext pizzaAppDbContext)
        {
            _pizzaAppDbContext = pizzaAppDbContext;
        }
        public void DeleteById(int id)
        {
            Feedback feedback = _pizzaAppDbContext.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            _pizzaAppDbContext.Feedbacks.Remove(feedback);
            _pizzaAppDbContext.SaveChanges();
        }

        public List<Feedback> GetAll()
        {
            return _pizzaAppDbContext.Feedbacks.ToList();
        }

        public Feedback GetById(int id)
        {
            return _pizzaAppDbContext.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {
            _pizzaAppDbContext.Feedbacks.Add(entity); 
            return _pizzaAppDbContext.SaveChanges(); 
        }

        public void Update(Feedback entity)
        {
            _pizzaAppDbContext.Feedbacks.Update(entity);
            _pizzaAppDbContext.SaveChanges(); 
        }
    }
}
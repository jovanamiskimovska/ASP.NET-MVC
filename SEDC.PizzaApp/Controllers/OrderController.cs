using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            List<Order> orders = StaticDb.Orders;
            return View(orders);
        }

        [Route("Order/Details/{id?}")]
        public IActionResult Details (int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }
            else
            {
                Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
                if(order == null)
                {
                    return new EmptyResult();
                }
                else
                {
                    return View(order);
                }
            }
        }
        [Route("Order/JsonData")]

        public IActionResult JsonData()
        {
            Order newOrder = new Order()
            {
                Id = 3,
                Pizza = StaticDb.Pizzas.Last(),
                User = StaticDb.Users.First(),
                PaymentMethod = Models.Enums.PaymentMethod.Cash
            };
            return new JsonResult(newOrder);
        }

        public IActionResult RedirectToHomeController()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}

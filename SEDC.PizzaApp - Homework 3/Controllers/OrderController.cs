using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            List<Order> ordersDb = StaticDb.Orders;
            List<OrderListViewModel> orderListViewModel = ordersDb.Select(x => OrderMapper.OrderToOrderListViewModel(x)).ToList();
            ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Title"] = "Orders list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();
            ViewData["FirstUser"] = StaticDb.Users.First();

            return View(orderListViewModel);
        }

        [Route("Order/Details/{id?}")]
        public IActionResult Details (int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }
            ViewBag.Message = "You are on the order details page";
            ViewBag.User = StaticDb.Users.First();
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if(orderDb == null)
            {
                return new EmptyResult();
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View("ResourceNotFound");
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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound"); 
            }

            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }

    }
}

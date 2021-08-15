using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            ViewData["Title"] = "Pizza list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            List<PizzaViewModel> pizzaViewModel = pizzas.Select(x => x.PizzaToPizzaExtensionViewModel()).ToList();

            return View(pizzaViewModel); 
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }

            ViewData["Title"] = "Pizza Details Action";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            ViewBag.Message = "You are on the pizza details page";

            PizzaViewModel pizzaViewModel = pizza.PizzaToPizzaExtensionViewModel();
            ViewBag.PizzaViewModel = pizzaViewModel;
            return View(pizza);
        }
        [Route("SeePizzas")] 
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

    }
}

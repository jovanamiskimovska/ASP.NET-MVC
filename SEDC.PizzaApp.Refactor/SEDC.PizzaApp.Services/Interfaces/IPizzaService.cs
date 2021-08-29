using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System.Collections.Generic;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaListViewModel> GetAllPizzas();
        PizzaDetailsViewModel GetPizzaDetails(int id);
        void CreatePizza(PizzaViewModel pizzaViewModel);
    }
}

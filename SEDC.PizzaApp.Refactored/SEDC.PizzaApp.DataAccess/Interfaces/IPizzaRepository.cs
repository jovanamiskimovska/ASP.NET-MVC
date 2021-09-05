using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Interfaces
{
    public interface IPizzaRepository : IRepository<Pizza>
    {
        Pizza GetPizzaOnPromotion();
    }
}

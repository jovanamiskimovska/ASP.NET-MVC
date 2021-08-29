using SEDC.PizzaApp.Domain.Enums;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
   public class PizzaListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
    }
}

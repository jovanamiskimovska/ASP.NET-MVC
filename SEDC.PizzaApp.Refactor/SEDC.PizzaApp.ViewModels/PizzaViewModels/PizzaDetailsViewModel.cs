using SEDC.PizzaApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        public string Name { get; set; }
        [Display(Name = "Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
        [Display(Name = "Is on promotion")]
        public bool IsOnPromotion { get; set; }
    }
}

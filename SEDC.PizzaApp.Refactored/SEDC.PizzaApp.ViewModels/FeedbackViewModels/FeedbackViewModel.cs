using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.ViewModels.FeedbackViewModels
{
   public class FeedbackViewModel
    {
        public int Id { get; set; }
        [Display(Name = "User's Name")]
        public string Name { get; set; }
        [Display(Name = "User's email")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}

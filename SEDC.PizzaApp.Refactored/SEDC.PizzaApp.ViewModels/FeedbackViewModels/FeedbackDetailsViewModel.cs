using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.FeedbackViewModels
{
    public class FeedbackDetailsViewModel
    {
        [Display(Name = "User's name")]
        public string Name { get; set; }
        [Display(Name = "User's email")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        public string Message { get; set; }
       
        public int Id { get; set; }
    }
}

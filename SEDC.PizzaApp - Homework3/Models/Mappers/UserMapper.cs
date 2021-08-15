using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel UserToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                UserFullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}

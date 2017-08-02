using FoodTruck.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Models
{
    public class UserSession : IUserSession
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
    }
}

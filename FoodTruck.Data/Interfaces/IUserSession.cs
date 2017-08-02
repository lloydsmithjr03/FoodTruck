using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Interfaces
{
    public interface IUserSession
    {
        Guid Id { get; set; }
        string Email { get; set; }
        string FullName { get; set; }
        string UserName { get; set; }
    }
}

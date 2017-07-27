using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

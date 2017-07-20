using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Commands.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Ingrediant> Ingrediants { get; set; }

        public Recipe()
        {
            this.Id = Guid.NewGuid();
            this.Ingrediants = new List<Ingrediant>();
        }
    }
}

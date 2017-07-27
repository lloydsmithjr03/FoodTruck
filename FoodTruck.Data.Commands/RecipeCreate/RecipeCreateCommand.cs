using FoodTruck.Data.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FoodTruck.Data.Models;

namespace FoodTruck.Data.Commands.RecipeCreate

{
    public class RecipeCreateCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ingrediant> Ingrediants { get; set; }

        public RecipeCreateCommand()
        {
            Ingrediants = new List<Ingrediant>();
        }
    }
}

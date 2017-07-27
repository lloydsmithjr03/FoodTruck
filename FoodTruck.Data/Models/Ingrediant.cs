using FoodTruck.Data.Enums;
using System;

namespace FoodTruck.Data.Models
{
    public class Ingrediant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RecipeId { get; set; }
        public double Units { get; set; }
        public UnitOfMeasure UnitOfMeasure {get;set;}
    }
}
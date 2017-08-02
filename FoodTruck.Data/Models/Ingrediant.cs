using FoodTruck.Data.Enums;
using FoodTruck.Data.Interfaces;
using System;

namespace FoodTruck.Data.Models
{
    public class Ingrediant: IAuditable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RecipeId { get; set; }
        public double Units { get; set; }
        public UnitOfMeasure UnitOfMeasure {get;set;}
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
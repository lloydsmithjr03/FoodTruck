using FoodTruck.Data.Enums;
using System;

namespace FoodTruck.Data.Commands.Models
{
    public class Ingrediant
    {
        public Guid Id { get; set; }
        public double Units { get; set; }
        public UnitOfMeasure UnitOfMeasure {get;set;}
        public string Name { get; set; }

        public Ingrediant(int units, UnitOfMeasure unitOfMeasure, string name)
            :this((double)units, unitOfMeasure, name)
        {
        }
        public Ingrediant(double units, UnitOfMeasure unitOfMeasure, string name)
        {
            this.Units = units;
            this.UnitOfMeasure = unitOfMeasure;
            this.Name = name;
        }
    }
}
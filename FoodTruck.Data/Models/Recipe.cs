using FoodTruck.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Models
{
    public class Recipe: IAuditable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

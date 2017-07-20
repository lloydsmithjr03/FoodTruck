using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FoodTruck.Data.Commands.Models;
using Microsoft.Extensions.Configuration;

namespace FoodTruck.Data.Commands.Contexts
{
    public class FoodTruckContext: DbContext
    {
        private IConfigurationRoot _configuration { get; }
        public DbSet<Ingrediant> Ingrediants { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public FoodTruckContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<FoodTruckContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("FoodTruck"));
        }

        public FoodTruckContext(DbContextOptions options)
            :base(options)
        {
        }
    }
}

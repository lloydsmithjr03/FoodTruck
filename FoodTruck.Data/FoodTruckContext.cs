using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FoodTruck.Data.Models;
using Microsoft.Extensions.Configuration;

namespace FoodTruck.Data
{
    public class FoodTruckContext: DbContext
    {
        private IConfigurationRoot _configuration { get; }

        public DbSet<Ingrediant> Ingrediants { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
               

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("FoodTruck"));
        }
        
    }
}

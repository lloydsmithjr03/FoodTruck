using FoodTruck.Data.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FoodTruck.Data.Commands.Contexts;

namespace FoodTruck.Data.Commands.Commands
{
    public class RecipeCreatorCommand : ICommand
    {
        private DbContext _context;

        public RecipeCreatorCommand(DbContext context)
        {
            _context = context == null ? new FoodTruckContext() : context;
        }

        public void Execute()
        {
            
        }
    }
}

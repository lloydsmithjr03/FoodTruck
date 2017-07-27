using FoodTruck.Data.Commands.Interfaces;
using FoodTruck.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Commands.RecipeCreate
{
    public class RecipeCreateHandler : ICommandHandler<RecipeCreateCommand>
    {
        private readonly FoodTruckContext _context;

        public RecipeCreateHandler()
            :this(new FoodTruckContext())
        {
        }

        public RecipeCreateHandler(FoodTruckContext context)
        {
            _context = context;
        }

        public void Execute(RecipeCreateCommand command)
        {
            var validator = new RecipeCreateValidator();

            var results = validator.Validate(command);

            if(results.IsValid)
            {
                var recipe = new Recipe();

                recipe.Id = command.Id;
                recipe.Name = command.Name;
                recipe.Description = command.Description;

                _context.Recipes.Add(recipe);

                _context.Ingrediants.AddRange(command.Ingrediants);

                _context.SaveChanges();

                return;
            }
        }
    }
}

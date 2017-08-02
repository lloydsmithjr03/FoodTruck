using FoodTruck.Data.Commands.Interfaces;
using FoodTruck.Data.Helpers;
using FoodTruck.Data.Interfaces;
using FoodTruck.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Commands.RecipeCreate
{
    public class RecipeCreateHandler : ICommandHandler<RecipeCreateCommand>
    {
        private readonly FoodTruckContext _context;
        private readonly IUserSession _userSession;

        public RecipeCreateHandler()
            :this(new FoodTruckContext(), new UserSession())
        {
        }

        public RecipeCreateHandler(IUserSession userSession)
            :this(new FoodTruckContext(), userSession)
        {

        }

        public RecipeCreateHandler(FoodTruckContext context)
            :this(context, new UserSession())
        {
            
        }

        public RecipeCreateHandler(FoodTruckContext context, IUserSession userSession)
        {
            _context = context;
            _userSession = userSession;
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

                recipe.SetCreated(_userSession);
                recipe.SetUpdated(_userSession);

                _context.Recipes.Add(recipe);

                foreach(var ingrediant in command.Ingrediants)
                {
                    ingrediant.SetCreated(_userSession);
                    ingrediant.SetUpdated(_userSession);
                }

                _context.Ingrediants.AddRange(command.Ingrediants);

                _context.SaveChanges();

                return;
            }
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Commands.RecipeCreate
{
    public class RecipeCreateValidator: AbstractValidator<RecipeCreateCommand>
    {
        public RecipeCreateValidator()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Ingrediants).NotEmpty();
        }
    }
}

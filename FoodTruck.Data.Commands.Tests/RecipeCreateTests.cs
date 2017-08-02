using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodTruck.Data.Commands.RecipeCreate;
using System.Linq;
using FoodTruck.Data.Models;

namespace FoodTruck.Data.Commands.Tests
{
    [TestClass]
    public class RecipeCreateTests
    {
        private RecipeCreateCommand _recipeCreateCommand;
        private RecipeCreateValidator _recipeCreateValidator;

        [TestInitialize]
        public void RecipeCreateCommandAndValidator()
        {
            _recipeCreateCommand = new RecipeCreateCommand();
            _recipeCreateValidator = new RecipeCreateValidator();
        }

        [TestMethod]
        public void RecipeCreateCommandInitializesGuid()
        {
            Assert.AreNotEqual(_recipeCreateCommand.Id, Guid.Empty);
        }
        
        [TestMethod]
        public void RecipeCreateCommandIsNotValidIfNoNameIsProvided()
        {
            _recipeCreateCommand.Id = Guid.NewGuid();
            _recipeCreateCommand.Ingrediants = new List<Ingrediant>(){
                new Ingrediant
                {
                    Id = Guid.NewGuid(),
                    Name = "Salt",
                    RecipeId = _recipeCreateCommand.Id,
                    UnitOfMeasure = Enums.UnitOfMeasure.Teaspoon,
                    Units = 1
                }
            };
            var results = _recipeCreateValidator.Validate(_recipeCreateCommand);

            Assert.IsFalse(results.IsValid);
            Assert.IsTrue(results.Errors.Count > 0);
            Assert.IsNotNull(results.Errors.First(x => x.PropertyName == "Name"));
        }

        [TestMethod]
        public void RecipeCreateCommandIsNotValidIfNoIngrediantsAreProvided()
        {
            _recipeCreateCommand.Id = Guid.NewGuid();
            _recipeCreateCommand.Name = "Beef Stew";

            var results = _recipeCreateValidator.Validate(_recipeCreateCommand);

            Assert.IsFalse(results.IsValid);
            Assert.IsTrue(results.Errors.Count > 0);
            Assert.IsNotNull(results.Errors.First(x => x.PropertyName == "Ingrediants"));
        }

        [TestMethod]
        public void RecipeCreateCommandIsValid()
        {
            _recipeCreateCommand.Id = Guid.NewGuid();
            _recipeCreateCommand.Name = "Beef Stew";
            _recipeCreateCommand.Ingrediants = new List<Ingrediant>(){
                new Ingrediant
                {
                    Id = Guid.NewGuid(),
                    Name = "Salt",
                    RecipeId = _recipeCreateCommand.Id,
                    UnitOfMeasure = Enums.UnitOfMeasure.Teaspoon,
                    Units = 1
                }
            };

            var results = _recipeCreateValidator.Validate(_recipeCreateCommand);

            Assert.IsTrue(results.IsValid);
        }
    }
}

using FoodTruck.Data.Enums;
using FoodTruck.Data.Commands.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodTruck.Data.Commands.Tests
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void CreateNewRecipe()
        {
            var recipe = new Recipe();
            recipe.Name = "Gumbo Shrimp";
            recipe.Description = "Just like you'd find down in the Bayou";
            recipe.Ingrediants.Add(new Ingrediant(1, UnitOfMeasure.Cup, "Water"));

            Assert.IsTrue(recipe != null);
            Assert.IsTrue(recipe.Id != new Guid());
            Assert.AreEqual(recipe.Name, "Gumbo Shrimp");
            Assert.AreEqual(recipe.Description, "Just like you'd find down in the Bayou");
            Assert.AreNotEqual(recipe.Ingrediants.Count, 0);
            Assert.AreEqual(recipe.Ingrediants.First().Name, "Water");
            Assert.AreEqual(recipe.Ingrediants.First().UnitOfMeasure, UnitOfMeasure.Cup);
            Assert.AreEqual(recipe.Ingrediants.First().Units, 1.0);
        }
    }
}

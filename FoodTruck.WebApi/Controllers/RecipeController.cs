using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodTruck.Data.Commands.RecipeCreate;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodTruck.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public RecipeCreateCommand Get()
        {
            return new RecipeCreateCommand();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]RecipeCreateCommand command)
        {
            var recipeCreateHandler = new RecipeCreateHandler();

            recipeCreateHandler.Execute(command);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

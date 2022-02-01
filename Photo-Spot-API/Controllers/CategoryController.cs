using DataAccess.DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Photo_Spot_API.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        // GET api/<controller>
        public List<CategoryModel> Get()
        {
            CategoryData data = new CategoryData();

            var categories = data.GetCategories();
            //List<string> returnValue = new List<string>();

            
            //foreach (CategoryModel c in categories)
            //{
            //    returnValue.Add(c.Title);
            //}
            return categories;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
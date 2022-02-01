using DataAccess.DataAccess;
using DataAccess.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Photo_Spot_API.Controllers
{
    [Authorize]
    public class RatingController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public List<RatingModel> Post([FromBody] AddRatingModel value)
        {
            RatingData data = new RatingData();
            value.UserId = RequestContext.Principal.Identity.GetUserId();
            data.AddRating(value);
            return data.GetRatingsForPost(value.PostId);
            //return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<controller>
        public List<RatingModel> Delete(int id)
        {
            AddRatingModel value = new AddRatingModel();
            value.PostId = id;
            RatingData data = new RatingData();
            value.UserId = RequestContext.Principal.Identity.GetUserId();
            data.DeleteRating(value);
            return data.GetRatingsForPost(value.PostId);
        }
    }
}
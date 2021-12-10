using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Photo_Spot_API.Controllers
{
    [Authorize]
    public class PictureController : ApiController
    {
        //// GET: api/Picture
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Picture/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Picture
        //public void Post([FromBody]string value)
        //{
            
        //}
        [HttpPost]
        public HttpResponseMessage UploadFiles()
        {
            string userId = User.Identity.GetUserId();


            //Create the Directory.
            string path = HttpContext.Current.Server.MapPath($"~/Posts/{userId}/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (HttpContext.Current.Request.Files?.Count == 0)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No File in request");
            }
            //Fetch the File.
            HttpPostedFile postedFile = HttpContext.Current.Request.Files[0];

            //Fetch the File Name.
            string fileName = Path.GetFileName(postedFile.FileName);

            //Save the File.
            postedFile.SaveAs(path + fileName);

            //Send OK Response to Client.
            return Request.CreateResponse(HttpStatusCode.OK, path + fileName);
        }

        //// PUT: api/Picture/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Picture/5
        //public void Delete(int id)
        //{
        //}
    }
}

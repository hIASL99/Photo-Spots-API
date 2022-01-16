using DataAccess.DataAccess;
using Microsoft.AspNet.Identity;
using Photo_Spot_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Photo_Spot_API.Controllers
{
    [Authorize]
    public class PhotosController : ApiController
    {
        // GET api/photos
        public List<PhotoModel> Get()
        {
            PhotosData data = new PhotosData();
            return data.GetAllPhotos();
        }
        [Route("api/photos/myPhotos")]
        public List<PhotoModel> GetAllFromUser()
        {
            string UserId = RequestContext.Principal.Identity.GetUserId();
            PhotosData data = new PhotosData();
            return data.GetAllMyPhotos(UserId);
        }
        // GET: api/photos/5
        public PhotoModel Get(int id)
        {
            PhotosData data = new PhotosData();
            return data.GetPhoto(id);
        }

        // POST: api/photos
        public HttpResponseMessage Post([FromBody] PhotoModel photo)
        {
            PhotosData data = new PhotosData();
            photo.UserId = RequestContext.Principal.Identity.GetUserId();
            data.PostNewPhoto(photo);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/photos/5
        public HttpResponseMessage PUT([FromBody] PhotoModel photo)
        {
            PhotosData data = new PhotosData();

            data.PutPhoto(photo);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/photos/5
        public HttpResponseMessage Delete(int id)
        {
            PhotosData data = new PhotosData();

            data.DeletePhoto(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }



    }
}
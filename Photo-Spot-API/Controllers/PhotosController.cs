using DataAccess.DataAccess;
using Photo_Spot_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
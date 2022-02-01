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
            RatingData ratingData = new RatingData();
            CategoryData categoryData = new CategoryData();
            CommentData commentData = new CommentData();
            var photos =  data.GetAllPhotos();
            foreach(var p in photos)
            {
                p.Comments = commentData.GetCommentsForPost(p.Id);
                p.Categories = categoryData.GetCategoriesForPost(p.Id).Select(tempresult => tempresult.Title ).ToList();
                p.Rating = ratingData.GetRatingsForPost(p.Id);
            }
            return photos;
        }
        [Route("api/photos/myPhotos")]
        public List<PhotoModel> GetAllFromUser()
        {
            string UserId = RequestContext.Principal.Identity.GetUserId();
            PhotosData data = new PhotosData();
            RatingData ratingData = new RatingData();
            CategoryData categoryData = new CategoryData();
            CommentData commentData = new CommentData();
            var photos = data.GetAllMyPhotos(UserId);

            foreach (var p in photos)
            {
                p.Comments = commentData.GetCommentsForPost(p.Id);
                p.Categories = categoryData.GetCategoriesForPost(p.Id).Select(tempresult => tempresult.Title).ToList();
                p.Rating = ratingData.GetRatingsForPost(p.Id);
            }
            return photos;

        }
        // GET: api/photos/5
        public PhotoModel Get(int id)
        {
            PhotosData data = new PhotosData();
            RatingData ratingData = new RatingData();
            CategoryData categoryData = new CategoryData();
            CommentData commentData = new CommentData();
            var photo = data.GetPhoto(id);

            photo.Comments = commentData.GetCommentsForPost(photo.Id);
            photo.Categories = categoryData.GetCategoriesForPost(photo.Id).Select(tempresult => tempresult.Title).ToList();
            photo.Rating = ratingData.GetRatingsForPost(photo.Id);
            
            return photo;

        }

        // POST: api/photos
        public HttpResponseMessage Post([FromBody] PhotoModel photo)
        {
            PhotosData data = new PhotosData();
            CategoryData catData = new CategoryData();
            photo.UserId = RequestContext.Principal.Identity.GetUserId();
            int id = data.PostNewPhoto(photo);
            catData.AddCategories(photo.Categories, id);
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
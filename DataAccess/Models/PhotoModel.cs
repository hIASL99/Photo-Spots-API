using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Photo_Spot_API.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
        public Double LocationLongitude { get; set; }
        public Double LocationLatitude { get; set; }
        public Double LocationAltitude { get; set; }
        public string UserName { get; set; }
        public List<RatingModel> Rating { get; set; }
        public List<string> Categories { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
    
}
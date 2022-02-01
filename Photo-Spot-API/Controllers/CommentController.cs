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
    public class CommentController : ApiController
    {
        public List<CommentModel> Post([FromBody] UploadCommentModel value)
        {
            CommentData data = new CommentData();
            value.UserId = RequestContext.Principal.Identity.GetUserId();
            var newcomments = data.AddComment(value.Text, value.PostId, value.UserId);
            return newcomments;
            //return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}

using DataAccess.Internal;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class CommentData
    {
        public List<CommentModel> GetCommentsForPost(int PostId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { PostId = PostId };

            var result = sql.LoadData<CommentModel, dynamic>("dbo.spGetCommentForPost", p, "DefaultConnection");

            return result;
        }
        public List<CommentModel> AddComment(string Text, int PostId, string UserId)
        {
            SqlDataAccess sql = new SqlDataAccess();
            
            var p = new
            {
                PostId = PostId,
                Text = Text,
                UserId = UserId
            };

            sql.SaveData<dynamic>("dbo.spAddComment", p, "DefaultConnection");

            return GetCommentsForPost(PostId);
        }
    }
}

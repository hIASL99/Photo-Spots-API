using DataAccess.Internal;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class RatingData
    {
        public void AddRating(AddRatingModel rating)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new {UserId = rating.UserId,
                         PostId = rating.PostId,
                         Rating = rating.Rating};

            sql.SaveData<dynamic>("dbo.spAddRating", p, "DefaultConnection");
        }
        public void DeleteRating(AddRatingModel rating)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                UserId = rating.UserId,
                PostId = rating.PostId
            };

            sql.SaveData<dynamic>("dbo.spDeleteRating", p, "DefaultConnection");
        }

        //public Dictionary<string, bool> GetRatingsForPost(int Id)
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var p = new { Id = Id };

        //    var result = sql.LoadData<RatingDictionaryModel, dynamic>("dbo.spGetAllRatingsForPost", p, "DefaultConnection");

        //    Dictionary<string, bool> ratings = new Dictionary<string, bool>();

        //    foreach(RatingDictionaryModel r in result)
        //    {
        //        ratings.Add(r.UserId, r.Rating);
        //    }

        //    return ratings;
        //}
        public List<RatingModel> GetRatingsForPost(int Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var result = sql.LoadData<RatingModel, dynamic>("dbo.spGetAllRatingsForPost", p, "DefaultConnection");


            return result;
        }

    }
    
}

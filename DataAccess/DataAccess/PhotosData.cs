using DataAccess.Internal;
using Photo_Spot_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess.DataAccess
{
    public class PhotosData
    {
        public List<PhotoModel> GetAllPhotos()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { };

            var result = sql.LoadData<PhotoModel, dynamic>("dbo.spGetAllPhotos", p, "DefaultConnection");

            return result;
        }
        public PhotoModel GetPhoto(int id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new {id = id };

            var result = sql.LoadData<PhotoModel, dynamic>("dbo.spGetPhoto", p, "DefaultConnection").First();

            return result;
        }

        public void PostNewPhoto(PhotoModel data)
        {
            SqlDataAccess sql = new SqlDataAccess();

            

            var p = new {   Photo = data.Photo,
                            Title = data.Title,
                            Description = data.Description,
                            Location = data.Location
            };

            sql.SaveData<dynamic>("dbo.spPostNewPhoto", p, "DefaultConnection");
        }
        public void PutPhoto(PhotoModel data)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
                Location = data.Location
            };

            sql.SaveData<dynamic>("dbo.spChangePhoto", p, "DefaultConnection");
        }
        public void DeletePhoto(int Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = Id
            };

            sql.SaveData<dynamic>("dbo.spDeletePhoto", p, "DefaultConnection");
        }
    }
}

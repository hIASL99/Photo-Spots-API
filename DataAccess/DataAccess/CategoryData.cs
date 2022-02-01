using DataAccess.Internal;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class CategoryData
    {
        public List<CategoryModel> GetCategories()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { };

            var result = sql.LoadData<CategoryModel, dynamic>("dbo.spGetCategories", p, "DefaultConnection");

            return result;
        }
        public List<CategoryModel> GetCategoriesForPost(int PostId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new {PostId = PostId };

            var result = sql.LoadData<CategoryModel, dynamic>("dbo.spGetCatgeoriesForPost", p, "DefaultConnection");

            return result;
        }
        public void AddCategories(List<string> categories, int id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            foreach(var category in categories)
            {
                var p = new
                {
                    Category = category,
                    PhotoId = id
                };

                sql.SaveData<dynamic>("dbo.spAddCategoryToPhoto", p, "DefaultConnection");
            }
            
        }
    }
}

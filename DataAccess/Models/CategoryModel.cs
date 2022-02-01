using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CategoryModel
    {
        //public int Id { get; set; }
        public String Title { get; set; }
    }
    public class AddCategoryToPhotoModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
    }
}

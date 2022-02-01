using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class RatingModel
    {
        public string UserId { get; set; }
        public bool Rating { get; set; }

    }
    public class AddRatingModel
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
        public bool Rating { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CommentModel
    {
        public string UserName { get; set; }
        public string Text { get; set; }
    }
    public class UploadCommentModel
    {
        public string UserId { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
    }
}

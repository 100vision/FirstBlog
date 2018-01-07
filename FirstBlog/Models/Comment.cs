using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstBlog.Models
{
    public class Comment
    {
        public int Commentid { get; set; }
        public string CommentBody { get; set; }
        public string person { get; set; }
        public DateTime CommentDate { get; set; }
        public int JournalID { get; set; }
    }
}
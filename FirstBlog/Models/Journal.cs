using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstBlog.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; } 
        public ICollection<Comment> Comments { get; set; }

    }
}
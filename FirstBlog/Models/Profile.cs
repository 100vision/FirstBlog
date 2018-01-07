using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstBlog.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }

    }
}
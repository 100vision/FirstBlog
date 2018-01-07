using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstBlog.Models
{
    public class BlogDB:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Journal> Journals { get; set; }
        //public DbSet<Profile> Profiles { get; set; }


    }
}
namespace FirstBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstBlog.Models.BlogDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "FirstBlog.Models.BlogDB";
        }

        protected override void Seed(FirstBlog.Models.BlogDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace FirstBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Commentid = c.Int(nullable: false, identity: true),
                        CommentBody = c.String(),
                        person = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        JournalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Commentid)
                .ForeignKey("dbo.Journals", t => t.JournalID, cascadeDelete: true)
                .Index(t => t.JournalID);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "JournalID", "dbo.Journals");
            DropIndex("dbo.Comments", new[] { "JournalID" });
            DropTable("dbo.Journals");
            DropTable("dbo.Comments");
        }
    }
}

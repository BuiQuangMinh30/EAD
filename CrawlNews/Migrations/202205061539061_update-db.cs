namespace CrawlNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Category", c => c.String());
            AddColumn("dbo.Sourses", "SubUrl", c => c.String());
            AddColumn("dbo.Sourses", "SelectorDescription", c => c.String());
            AddColumn("dbo.Sourses", "Category", c => c.String());
            DropColumn("dbo.Articles", "CategoryId");
            DropColumn("dbo.Sourses", "SelectorDescrition");
            DropColumn("dbo.Sourses", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sourses", "CategoryId", c => c.String());
            AddColumn("dbo.Sourses", "SelectorDescrition", c => c.String());
            AddColumn("dbo.Articles", "CategoryId", c => c.String());
            DropColumn("dbo.Sourses", "Category");
            DropColumn("dbo.Sourses", "SelectorDescription");
            DropColumn("dbo.Sourses", "SubUrl");
            DropColumn("dbo.Articles", "Category");
        }
    }
}

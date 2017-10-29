namespace Demo_Project001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilkMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        TeamName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamName)
                .Index(t => t.TeamName);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamName = c.String(nullable: false, maxLength: 30),
                        City = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.TeamName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamName", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamName" });
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}

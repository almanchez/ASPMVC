namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artistas",
                c => new
                    {
                        ArtistaID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Artistas");
        }
    }
}

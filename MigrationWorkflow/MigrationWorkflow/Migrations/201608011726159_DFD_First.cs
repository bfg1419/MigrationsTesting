namespace MigrationWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DFD_First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cat",
                c => new
                    {
                        CatId = c.Long(nullable: false, identity: true),
                        FavoriteNappingSpot = c.String(),
                        HumanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CatId);
            
            CreateTable(
                "dbo.Dog",
                c => new
                    {
                        DogId = c.Long(nullable: false, identity: true),
                        Breed = c.String(),
                        HumanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.DogId)
                .ForeignKey("dbo.Human", t => t.HumanId)
                .Index(t => t.HumanId);
            
            CreateTable(
                "dbo.Human",
                c => new
                    {
                        HumanId = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        DogId = c.Long(nullable: false),
                        CatId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.HumanId)
                .ForeignKey("dbo.Cat", t => t.CatId)
                .Index(t => t.CatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dog", "HumanId", "dbo.Human");
            DropForeignKey("dbo.Human", "CatId", "dbo.Cat");
            DropIndex("dbo.Human", new[] { "CatId" });
            DropIndex("dbo.Dog", new[] { "HumanId" });
            DropTable("dbo.Human");
            DropTable("dbo.Dog");
            DropTable("dbo.Cat");
        }
    }
}

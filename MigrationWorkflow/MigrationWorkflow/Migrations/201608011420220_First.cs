namespace MigrationWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        CatId = c.Long(nullable: false, identity: true),
                        FavoriteNappingSpot = c.String(),
                        HumanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CatId);
            
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        DogId = c.Long(nullable: false, identity: true),
                        Breed = c.String(),
                        HumanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.DogId)
                .ForeignKey("dbo.Humen", t => t.HumanId, cascadeDelete: true)
                .Index(t => t.HumanId);
            
            CreateTable(
                "dbo.Humen",
                c => new
                    {
                        HumanId = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        DogId = c.Long(nullable: false),
                        CatId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.HumanId)
                .ForeignKey("dbo.Cats", t => t.CatId, cascadeDelete: true)
                .Index(t => t.CatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dogs", "HumanId", "dbo.Humen");
            DropForeignKey("dbo.Humen", "CatId", "dbo.Cats");
            DropIndex("dbo.Humen", new[] { "CatId" });
            DropIndex("dbo.Dogs", new[] { "HumanId" });
            DropTable("dbo.Humen");
            DropTable("dbo.Dogs");
            DropTable("dbo.Cats");
        }
    }
}

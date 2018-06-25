namespace MVCSecurity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCloths : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clothings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        CanDryClean = c.Boolean(nullable: false),
                        FirstProduced = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clothings");
        }
    }
}

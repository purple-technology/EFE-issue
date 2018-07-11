namespace TestingORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Server",
                c => new
                    {
                        ServerID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Platform = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServerID)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("public.Server", new[] { "Name" });
            DropTable("public.Server");
        }
    }
}

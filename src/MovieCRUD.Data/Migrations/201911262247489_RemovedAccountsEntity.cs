namespace MovieCRUD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAccountsEntity : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Password = c.String(nullable: false)
                })
                .PrimaryKey(t => t.Id);
        }
    }
}

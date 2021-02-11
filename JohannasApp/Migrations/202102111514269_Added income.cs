namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedincome : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Incomes");
        }
    }
}

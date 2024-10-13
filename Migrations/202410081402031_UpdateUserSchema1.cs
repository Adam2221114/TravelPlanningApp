namespace PlanningApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserSchema1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Users", "UserAccount", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserAccount", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Users", "UserId");
        }
    }
}

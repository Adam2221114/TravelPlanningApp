namespace PlanningApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserAccount", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserAccount");
        }
    }
}

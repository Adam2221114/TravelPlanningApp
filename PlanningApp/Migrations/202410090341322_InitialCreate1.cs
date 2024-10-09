namespace PlanningApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Nickname", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Nickname");
        }
    }
}

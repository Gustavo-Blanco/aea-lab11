namespace UniversityCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enablestundentstable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Enable", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Enable");
        }
    }
}

namespace UniversityCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enableofficeAssignmenttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeAssignments", "Enable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "Enable");
        }
    }
}

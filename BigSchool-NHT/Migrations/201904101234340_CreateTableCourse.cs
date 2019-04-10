namespace BigSchool_NHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
    }
}

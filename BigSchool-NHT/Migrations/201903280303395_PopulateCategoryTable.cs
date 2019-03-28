namespace BigSchool_NHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (ID, NAME) VALUES (1,'Development')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (2,'Business')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}

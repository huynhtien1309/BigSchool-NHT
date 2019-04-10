namespace BigSchool_NHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories(Id, Name) values(1,'Development')");
            Sql("insert into Categories(Id, Name) values(2,'Business')");
            Sql("insert into Categories(Id, Name) values(3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberInStock : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberInStock = 5 WHERE Id = 1");
            Sql("UPDATE Movies SET NumberInStock = 7 WHERE Id = 2");
            Sql("UPDATE Movies SET NumberInStock = 13 WHERE Id = 3");
            Sql("UPDATE Movies SET NumberInStock = 2 WHERE Id = 4");
            Sql("UPDATE Movies SET NumberInStock = 8 WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}

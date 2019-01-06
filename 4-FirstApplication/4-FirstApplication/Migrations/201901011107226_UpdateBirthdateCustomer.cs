namespace _4_FirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate='1997/12/13 00:00:00' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}

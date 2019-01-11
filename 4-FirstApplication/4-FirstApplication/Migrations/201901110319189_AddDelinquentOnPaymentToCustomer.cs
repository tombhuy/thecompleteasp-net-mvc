namespace _4_FirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDelinquentOnPaymentToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsDelinquentOnPayment", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsDelinquentOnPayment");
        }
    }
}

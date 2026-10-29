namespace PersonalFinances.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertMoneyColumnsToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "InitialBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Accounts", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Movements", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Movements", "Increase", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Movements", "Decrease", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.CreditCards", "Limit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Projects", "Budget", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Transfers", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Transfers", "Tax", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transfers", "Tax", c => c.Double());
            AlterColumn("dbo.Transfers", "Value", c => c.Double(nullable: false));
            AlterColumn("dbo.Projects", "Budget", c => c.Double());
            AlterColumn("dbo.CreditCards", "Limit", c => c.Double(nullable: false));
            AlterColumn("dbo.Movements", "Decrease", c => c.Double());
            AlterColumn("dbo.Movements", "Increase", c => c.Double());
            AlterColumn("dbo.Movements", "Value", c => c.Double(nullable: false));
            AlterColumn("dbo.Accounts", "Balance", c => c.Double(nullable: false));
            AlterColumn("dbo.Accounts", "InitialBalance", c => c.Double(nullable: false));
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE SignUpFee = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE SignUpFee = 30");
            Sql("UPDATE MembershipTypes SET Name = 'Quartelty' WHERE SignUpFee = 90");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE SignUpFee = 300");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Alive.OA.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable20190509 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Role", "RoleName", c => c.String(maxLength: 20));
            AlterColumn("dbo.UserInfo", "UserName", c => c.String(maxLength: 20));
            AlterColumn("dbo.UserInfo", "Pwd", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfo", "Pwd", c => c.String());
            AlterColumn("dbo.UserInfo", "UserName", c => c.String());
            AlterColumn("dbo.Role", "RoleName", c => c.String());
        }
    }
}

namespace Alive.OA.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdatabaseAliveOA20190509 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserName = c.String(),
                        Pwd = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfo");
            DropTable("dbo.Role");
        }
    }
}

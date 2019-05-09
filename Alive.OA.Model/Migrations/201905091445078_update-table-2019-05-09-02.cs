namespace Alive.OA.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable2019050902 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoRoles",
                c => new
                    {
                        UserInfo_ID = c.Guid(nullable: false),
                        Role_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfo_ID, t.Role_ID })
                .ForeignKey("dbo.UserInfo", t => t.UserInfo_ID, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.Role_ID, cascadeDelete: true)
                .Index(t => t.UserInfo_ID)
                .Index(t => t.Role_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoRoles", "Role_ID", "dbo.Role");
            DropForeignKey("dbo.UserInfoRoles", "UserInfo_ID", "dbo.UserInfo");
            DropIndex("dbo.UserInfoRoles", new[] { "Role_ID" });
            DropIndex("dbo.UserInfoRoles", new[] { "UserInfo_ID" });
            DropTable("dbo.UserInfoRoles");
        }
    }
}

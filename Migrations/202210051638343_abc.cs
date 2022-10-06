namespace EmpProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpID = c.Int(nullable: false),
                        EmpName = c.String(nullable: false),
                        Dept = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        Marital_status = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Salary = c.String(nullable: false),
                        PhoneNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpName = c.String(nullable: false),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Emps", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sals", "EmpID", "dbo.Emps");
            DropIndex("dbo.Sals", new[] { "EmpID" });
            DropTable("dbo.Sals");
            DropTable("dbo.Emps");
        }
    }
}

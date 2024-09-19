namespace CodeFirstMvcTask1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        id = c.Int(nullable: false),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Teachers", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        StudentDetailsID = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentDetailsID)
                .ForeignKey("dbo.Students", t => t.StudentDetailsID)
                .Index(t => t.StudentDetailsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDetails", "StudentDetailsID", "dbo.Students");
            DropForeignKey("dbo.Classes", "id", "dbo.Teachers");
            DropIndex("dbo.StudentDetails", new[] { "StudentDetailsID" });
            DropIndex("dbo.Classes", new[] { "id" });
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Classes");
        }
    }
}

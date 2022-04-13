namespace ConsoleApp_EF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coursestudentrealtions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CourseStudents", new[] { "StudentId" });
            DropIndex("dbo.CourseStudents", new[] { "CourseId" });
            DropForeignKey("dbo.CourseStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "CourseId", "dbo.Courses");
            DropTable("dbo.CourseStudents");
        }
    }
}

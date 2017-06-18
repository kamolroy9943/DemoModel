namespace ModelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Affects",
                c => new
                    {
                        AffectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AffectId)
                .ForeignKey("dbo.ChangeProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.ChangeProjects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ChangeRequestor = c.String(nullable: false),
                        ChangeNo = c.String(nullable: false),
                        RequestedChange = c.String(nullable: false),
                        ChangeReason = c.String(nullable: false),
                        AlternativeConsideration = c.String(nullable: false),
                        TechnicalChanges = c.String(nullable: false),
                        RiskConsiderationn = c.String(nullable: false),
                        ReasourceCost = c.Double(nullable: false),
                        ImplementationQuality = c.String(nullable: false),
                        Justification = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        CatagoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CatagoryId)
                .ForeignKey("dbo.ChangeProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Depositions",
                c => new
                    {
                        DepositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepositionId)
                .ForeignKey("dbo.ChangeProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Depositions", "ProjectId", "dbo.ChangeProjects");
            DropForeignKey("dbo.Catagories", "ProjectId", "dbo.ChangeProjects");
            DropForeignKey("dbo.Affects", "ProjectId", "dbo.ChangeProjects");
            DropIndex("dbo.Depositions", new[] { "ProjectId" });
            DropIndex("dbo.Catagories", new[] { "ProjectId" });
            DropIndex("dbo.Affects", new[] { "ProjectId" });
            DropTable("dbo.Depositions");
            DropTable("dbo.Catagories");
            DropTable("dbo.ChangeProjects");
            DropTable("dbo.Affects");
        }
    }
}

namespace JBB.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Offer",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Company_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.Company_ID)
                .Index(t => t.Company_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offer", "Company_ID", "dbo.Company");
            DropIndex("dbo.Offer", new[] { "Company_ID" });
            DropTable("dbo.Offer");
            DropTable("dbo.Company");
        }
    }
}

namespace RentExtreme2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addseveralid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirmsServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firms", t => t.FirmId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.FirmId)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FirmsServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.FirmsServices", "FirmId", "dbo.Firms");
            DropIndex("dbo.FirmsServices", new[] { "ServiceId" });
            DropIndex("dbo.FirmsServices", new[] { "FirmId" });
            DropTable("dbo.FirmsServices");
        }
    }
}

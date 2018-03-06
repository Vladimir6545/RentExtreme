namespace RentExtreme2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addurltoservice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "ImageUrl");
        }
    }
}

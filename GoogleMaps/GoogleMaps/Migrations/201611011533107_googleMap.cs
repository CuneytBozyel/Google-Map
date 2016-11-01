namespace GoogleMaps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class googleMap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        latitude = c.String(),
                        Longitude = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}

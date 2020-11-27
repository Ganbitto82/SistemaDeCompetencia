namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion15 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Fixture", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fixture", "Tipo", c => c.String(nullable: false));
        }
    }
}

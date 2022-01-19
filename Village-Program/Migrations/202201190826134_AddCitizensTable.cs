namespace Village_Program.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCitizensTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        FatherName = c.String(),
                        Gender = c.String(),
                        IsBornInVillage = c.Boolean(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Citizens");
        }
    }
}

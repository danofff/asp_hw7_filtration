namespace asp_hw7_filtration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table_visitors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyVisitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Ip = c.String(),
                        Url = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyVisitors");
        }
    }
}

namespace CodeFirstTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblcountries",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.tblstates",
                c => new
                    {
                        stid = c.Int(nullable: false, identity: true),
                        cid = c.Int(nullable: false),
                        sname = c.String(),
                    })
                .PrimaryKey(t => t.stid);
            
            CreateTable(
                "dbo.tblstudents",
                c => new
                    {
                        sid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        country = c.Int(nullable: false),
                        state = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblstudents");
            DropTable("dbo.tblstates");
            DropTable("dbo.tblcountries");
        }
    }
}

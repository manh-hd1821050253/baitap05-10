namespace HoangDucManh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBLopHoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc");
        }
    }
}

namespace Lap_4_5_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'LapTrinhC')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'KyThuatLapTrinh')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'CTDL')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4,'CSDL')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (5,'LapTrinhTrenMoiTruongWindows')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (6,'LapTrinhWeb')");
        }
        
        public override void Down()
        {
        }
    }
}

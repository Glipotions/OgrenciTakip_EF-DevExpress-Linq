using System.Data.Entity.Migrations;
using OgrenciTakip.Data.Context;

namespace OgrenciTakip.Data.OgrenciTakipYonetimMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipYonetimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
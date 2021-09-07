using OgrenciTakip.Data.Context;
using System.Data.Entity.Migrations;

namespace OgrenciTakip.Data.OgrenciTakipMigration
{
	public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true; //Veri kaybı durumu olsun mu?
			
		}
	}
}

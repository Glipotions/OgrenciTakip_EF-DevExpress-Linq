using OgrenciYazilim.Data.OgrenciTakipMigration;
using OgrenciYazilim.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OgrenciYazilim.Data.Context
{
	public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext, Configuration>
	{
		public OgrenciTakipContext()
		{
			Configuration.LazyLoadingEnabled = false;	//
		}

		public OgrenciTakipContext(string connectionString) : base(connectionString)
		{
			Configuration.LazyLoadingEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
		}

		//Veritabanýndaki tablolarla Programýn baðlantý kurulduðu yer

		public DbSet<Il> Il { get; set; }
		public DbSet<Ilce> Ilce { get; set; }
		public DbSet<Okul> Okul { get; set; }

	}
}
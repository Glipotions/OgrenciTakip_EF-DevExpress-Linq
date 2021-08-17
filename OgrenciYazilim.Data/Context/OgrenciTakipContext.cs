using OgrenciTakip.Model;
using OgrenciTakip.Model.Entities;
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
			Configuration.LazyLoadingEnabled = false;   //
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

		//Veritaban�ndaki tablolarla Program�n ba�lant� kuruldu�u yer

		public DbSet<Il> Il { get; set; }
		public DbSet<Ilce> Ilce { get; set; }
		public DbSet<Okul> Okul { get; set; }
		public DbSet<Filtre> Filtre { get; set; }
		public DbSet<AileBilgi> AileBilgi { get; set; }
		public DbSet<IptalNedeni> IptalNedeni { get; set; }
		public DbSet<YabanciDil> YabanciDil { get; set; }

		public DbSet<Tesvik> Tesvik { get; set; }
		public DbSet<Kontenjan> Kontenjan { get; set; }
		public DbSet<Rehber> Rehber { get; set; }
		public DbSet<SinifGrup> SinifGrup { get; set; }
		public DbSet<Meslek> Meslek { get; set; }
		public DbSet<Yakinlik> Yakinlik { get; set; }
		public DbSet<Isyeri> Isyeri { get; set; }
		public DbSet<Gorev> Gorev { get; set; }
		public DbSet<IndirimTuru> IndirimTuru { get; set; }
		public DbSet<Evrak> Evrak { get; set; }
		public DbSet<Donem> Donem { get; set; }
		public DbSet<Sube> Sube { get; set; }
		public DbSet<Promosyon> Promosyon { get; set; }
		public DbSet<Servis> Servis { get; set; }
		public DbSet<Sinif> Sinif { get; set; }
		public DbSet<HizmetTuru> HizmetTuru { get; set; }
		public DbSet<Hizmet> Hizmet { get; set; }
		public DbSet<OzelKod> OzelKod { get; set; }
		public DbSet<Kasa> Kasa { get; set; }

	}
}
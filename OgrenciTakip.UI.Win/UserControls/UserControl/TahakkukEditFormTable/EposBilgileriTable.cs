using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
	public partial class EposBilgileriTable : BaseTablo
	{
		public EposBilgileriTable()
		{
			InitializeComponent();

			Business = new EposBilgileriBusiness();
			Tablo = tablo;
			EventsLoad();
			repositoryKartTuru.Items.AddEnum<EposKartTuru>();
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((EposBilgileriBusiness)Business).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EposBilgileriL>();
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;

			var row = new EposBilgileriL
			{
				TahakkukId = OwnerForm.Id,
				Insert = true
			};

			source.Add(row);

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colAdi;

			ButonEnabledDurumu(true);
		}

		protected internal override bool HataliGiris()
		{
			if (!TableValueChanged) return false;
			if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

			for (int i = 0; i < tablo.DataRowCount; i++)
			{
				var entity = tablo.GetRow<EposBilgileriL>(i);

				if (string.IsNullOrEmpty(entity.Adi))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colAdi;
					tablo.SetColumnError(colAdi, "Kart Sahibinin Adı Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.Soyadi))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colSoyadi;
					tablo.SetColumnError(colSoyadi, "Kart Sahibinin Soyadı Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.BankaAdi))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colBankaAdi;
					tablo.SetColumnError(colBankaAdi, "Banka Adı Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.KartNo))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colKartNo;
					tablo.SetColumnError(colKartNo, "Kart No Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.SonKullanmaTarihi))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colSonKullanmaTarihi;
					tablo.SetColumnError(colSonKullanmaTarihi, "Son Kullanma Tarihi Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.GuvenlikKodu))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colGuvenlikKodu;
					tablo.SetColumnError(colGuvenlikKodu, "Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz.");
				}

				if (!tablo.HasColumnErrors) continue;
				Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
				return true;
			}

			return false;
		}

		protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
		{
			base.Tablo_FocusedColumnChanged(sender, e);

			if (e.FocusedColumn == colBankaAdi)
				e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBanka, colBankaId);
		}
	}
}
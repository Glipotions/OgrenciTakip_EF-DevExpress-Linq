using DevExpress.XtraBars;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
	public partial class KardesBilgileriTable : BaseTablo
	{
		public KardesBilgileriTable()
		{
			InitializeComponent();

			Business = new KardesBilgileriBusiness();
			Tablo = tablo;
			EventsLoad();
			ShowItems = new BarItem[] { btnKartDuzenle };
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((KardesBilgileriBusiness)Business).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<KardesBilgileriL>();
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;
			ListeDisiTutulacakKayitlar = source.Cast<KardesBilgileriL>().Where(x => !x.Delete).Select(x => x.KardesTahakkukId).ToList();
			ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);

			var entities = ShowListForms<TahakkukListForm>.ShowDialogListForm(KartTuru.Tahakkuk, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<TahakkukL>();
			if (entities == null) return;

			foreach (var entity in entities)
			{
				var row = new KardesBilgileriL
				{
					TahakkukId = OwnerForm.Id,
					KardesTahakkukId = entity.Id,
					Adi = entity.Adi,
					Soyadi = entity.Soyadi,
					SinifAdi = entity.SinifAdi,
					KayitSekli = entity.KayitSekli,
					KayitDurumu = entity.KayitDurumu,
					IptalDurumu = entity.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
					SubeAdi = entity.SubeAdi,
					Insert = true
				};

				source.Add(row);
			}

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colAdi;

			ButonEnabledDurumu(true);
		}

		protected override void OpenEntity()
		{
			var entity = tablo.GetRow<KardesBilgileriL>();
			if (entity == null) return;
			ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.KardesTahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId); // aynı değilse sen farklı bir şube veya dönem kartı açmaya çalışıyorsun değişiklikler kayıt edilmeyecek diye uyarı vermesi için
		}
	}
}
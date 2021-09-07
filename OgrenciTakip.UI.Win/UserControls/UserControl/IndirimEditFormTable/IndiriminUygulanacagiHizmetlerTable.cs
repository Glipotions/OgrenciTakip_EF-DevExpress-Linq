using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.IndirimEditFormTable
{
	public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
	{
		public IndiriminUygulanacagiHizmetlerTable()
		{
			InitializeComponent();

			Business = new IndiriminUygulanacagiHizmetBilgileriBusiness();
			Tablo = tablo;
			EventsLoad();
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBusiness)Business).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndiriminUygulanacagiHizmetBilgileriL>();//(57:00 Indirimin Uygulanacağı hizmetler tablosu bölüm 2(3/6))
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;
			ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

			var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<HizmetL>();
			if (entities == null) return;

			foreach (var entity in entities)
			{
				var row = new IndiriminUygulanacagiHizmetBilgileriL
				{
					IndirimId = OwnerForm.Id,
					HizmetId = entity.Id,
					HizmetAdi = entity.HizmetAdi,
					IndirimTutari = 0,
					IndirimOrani = 0,
					SubeId = AnaForm.SubeId,
					DonemId = AnaForm.DonemId,
					Insert = true
				};

				source.Add(row);
			}

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colIndirimTutari;

			ButonEnabledDurumu(true);
		}

		protected internal override bool HataliGiris()
		{
			if (!TableValueChanged) return false;
			for (int i = 0; i < tablo.DataRowCount; i++)
			{
				var entity = tablo.GetRow<IndiriminUygulanacagiHizmetBilgileriL>(i);
				if (entity.IndirimTutari == 0 || entity.IndirimOrani == 0) continue;
				tablo.Focus();
				tablo.FocusedRowHandle = i;  //focuslanacağı satır
				Messages.HataMesaji("İndirim Tutarı veya İndirim Oranı Alanlarından Sadece Birinin Değeri Sıfırdan Büyük Olmalıdır!");
				return true;
			}

			return false;
		}
	}
}
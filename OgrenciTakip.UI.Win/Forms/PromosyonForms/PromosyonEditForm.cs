using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.PromosyonForms
{
	public partial class PromosyonEditForm : BaseEditForm
	{
		public PromosyonEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl1;
			Business = new PromosyonBusiness(myDataLayoutControl1);
			BaseKartTuru = KartTuru.Promosyon;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Promosyon() : ((PromosyonBusiness)Business).Single(FilterFunctions.Filter<Promosyon>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((PromosyonBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
			txtPromosyonAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Promosyon)OldEntity;

			txtKod.Text = entity.Kod;
			txtPromosyonAdi.Text = entity.PromosyonAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Promosyon
			{
				Id = Id,
				Kod = txtKod.Text,
				PromosyonAdi = txtPromosyonAdi.Text,
				Aciklama = txtAciklama.Text,
				SubeId = AnaForm.SubeId,
				DonemId = AnaForm.DonemId,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected override bool EntityInsert()
		{
			return ((PromosyonBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}

		protected override bool EntityUpdate()
		{
			return ((PromosyonBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}
	}
}
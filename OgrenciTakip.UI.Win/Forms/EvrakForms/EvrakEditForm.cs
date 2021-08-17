using OgrenciTakip.Business.General;
using OgrenciTakip.Model;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.EvrakForms
{
	public partial class EvrakEditForm : BaseEditForm
	{
		public EvrakEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new EvrakBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Evrak;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Evrak() : ((EvrakBusiness)Business).Single(FilterFunctions.Filter<Evrak>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((EvrakBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
			txtEvrakAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Evrak)OldEntity;

			txtKod.Text = entity.Kod;
			txtEvrakAdi.Text = entity.EvrakAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Evrak
			{
				Id = Id,
				Kod = txtKod.Text,
				EvrakAdi = txtEvrakAdi.Text,
				Aciklama = txtAciklama.Text,
				SubeId = AnaForm.SubeId,
				DonemId = AnaForm.DonemId,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected override bool EntityInsert()
		{
			return ((EvrakBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}

		protected override bool EntityUpdate()
		{
			return ((EvrakBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}
	}
}
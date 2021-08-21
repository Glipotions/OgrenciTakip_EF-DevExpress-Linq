using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
	public partial class IndirimTuruEditForm : BaseEditForm
	{
		public IndirimTuruEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new IndirimTuruBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.IndirimTuru;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new IndirimTuru() : ((IndirimTuruBusiness)Business).Single(FilterFunctions.Filter<IndirimTuru>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IndirimTuruBusiness)Business).YeniKodVer();
			txtIndirimAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (IndirimTuru)OldEntity;

			txtKod.Text = entity.Kod;
			txtIndirimAdi.Text = entity.IndirimTuruAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new IndirimTuru
			{
				Id = Id,
				Kod = txtKod.Text,
				IndirimTuruAdi = txtIndirimAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
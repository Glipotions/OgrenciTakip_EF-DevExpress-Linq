using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.TesvikForms
{
	public partial class TesvikEditForm : BaseEditForm
	{
		public TesvikEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new TesvikBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Tesvik;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Tesvik() : ((TesvikBusiness)Business).Single(FilterFunctions.Filter<Tesvik>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((TesvikBusiness)Business).YeniKodVer();
			txtTesvikAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Tesvik)OldEntity;

			txtKod.Text = entity.Kod;
			txtTesvikAdi.Text = entity.TesvikAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Tesvik
			{
				Id = Id,
				Kod = txtKod.Text,
				TesvikAdi = txtTesvikAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
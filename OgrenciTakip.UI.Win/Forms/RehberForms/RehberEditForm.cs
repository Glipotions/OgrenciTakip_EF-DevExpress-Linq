using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
	public partial class RehberEditForm : BaseEditForm
	{
		public RehberEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new RehberBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Rehber;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Rehber() : ((RehberBusiness)Business).Single(FilterFunctions.Filter<Rehber>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((RehberBusiness)Business).YeniKodVer();
			txtAdiSoyadi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Rehber)OldEntity;

			txtKod.Text = entity.Kod;
			txtAdiSoyadi.Text = entity.AdiSoyadi;
			txtTelefon1.Text = entity.Telefon1;
			txtTelefon2.Text = entity.Telefon2;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Rehber
			{
				Id = Id,
				Kod = txtKod.Text,
				AdiSoyadi = txtAdiSoyadi.Text,
				Telefon1 = txtTelefon1.Text,
				Telefon2 = txtTelefon2.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
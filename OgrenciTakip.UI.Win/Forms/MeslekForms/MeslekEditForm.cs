using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.MeslekForms
{
	public partial class MeslekEditForm : BaseEditForm
	{
		public MeslekEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new MeslekBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Meslek;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Meslek() : ((MeslekBusiness)Business).Single(FilterFunctions.Filter<Meslek>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((MeslekBusiness)Business).YeniKodVer();
			txtMeslekAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Meslek)OldEntity;

			txtKod.Text = entity.Kod;
			txtMeslekAdi.Text = entity.MeslekAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Meslek
			{
				Id = Id,
				Kod = txtKod.Text,
				MeslekAdi = txtMeslekAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
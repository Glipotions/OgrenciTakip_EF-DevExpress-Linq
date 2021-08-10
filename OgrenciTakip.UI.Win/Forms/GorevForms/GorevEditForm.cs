using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.GorevForms
{
	public partial class GorevEditForm : BaseEditForm
	{
		public GorevEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new GorevBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Gorev;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Gorev() : ((GorevBusiness)Business).Single(FilterFunctions.Filter<Gorev>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((GorevBusiness)Business).YeniKodVer();
			txtGorevAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Gorev)OldEntity;

			txtKod.Text = entity.Kod;
			txtGorevAdi.Text = entity.GorevAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Gorev
			{
				Id = Id,
				Kod = txtKod.Text,
				GorevAdi = txtGorevAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
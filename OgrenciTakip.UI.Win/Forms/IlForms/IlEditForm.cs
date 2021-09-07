using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IlForms
{
	public partial class IlEditForm : BaseEditForm
	{
		public IlEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new IlBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Il;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
				new Il() : ((IlBusiness)Business).Single(FilterFunctions.Filter<Il>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IlBusiness)Business).YeniKodVer();
			txtIlAdi.Focus();

		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Il)OldEntity;

			txtKod.Text = entity.Kod;
			txtIlAdi.Text = entity.IlAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Il
			{
				Id = Id,
				Kod = txtKod.Text,
				IlAdi = txtIlAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
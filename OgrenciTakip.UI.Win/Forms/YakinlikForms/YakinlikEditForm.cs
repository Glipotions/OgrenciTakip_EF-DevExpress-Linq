using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
	public partial class YakinlikEditForm : BaseEditForm
	{
		public YakinlikEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new YakinlikBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Yakinlik;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Yakinlik() : ((YakinlikBusiness)Business).Single(FilterFunctions.Filter<Yakinlik>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((YakinlikBusiness)Business).YeniKodVer();
			txtYakinlikAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Yakinlik)OldEntity;

			txtKod.Text = entity.Kod;
			txtYakinlikAdi.Text = entity.YakinlikAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Yakinlik
			{
				Id = Id,
				Kod = txtKod.Text,
				YakinlikAdi = txtYakinlikAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
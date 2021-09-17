using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
	public partial class YabanciDilEditForm : BaseEditForm
	{
		public YabanciDilEditForm()
		{
			InitializeComponent();


			DataLayoutControl = myDataLayoutControl;
			Business = new YabanciDilBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.YabanciDil;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new YabanciDil() : ((YabanciDilBusiness)Business).Single(FilterFunctions.Filter<YabanciDil>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((YabanciDilBusiness)Business).YeniKodVer();
			txtYabanciDilAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (YabanciDil)OldEntity;

			txtKod.Text = entity.Kod;
			txtYabanciDilAdi.Text = entity.DilAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new YabanciDil
			{
				Id = Id,
				Kod = txtKod.Text,
				DilAdi = txtYabanciDilAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}

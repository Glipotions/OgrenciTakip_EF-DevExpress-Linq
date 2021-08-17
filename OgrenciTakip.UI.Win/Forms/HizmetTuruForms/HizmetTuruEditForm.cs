using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Functions;

namespace OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
	public partial class HizmetTuruEditForm : BaseEditForm
	{
		public HizmetTuruEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new HizmetTuruBusiness(myDataLayoutControl);
			txtHizmetTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetTipi>()); //Combobox a item ekleme yeri
			BaseKartTuru = KartTuru.HizmetTuru;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new HizmetTuru() : ((HizmetTuruBusiness)Business).Single(FilterFunctions.Filter<HizmetTuru>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((HizmetTuruBusiness)Business).YeniKodVer();
			txtHizmetTuruAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (HizmetTuru)OldEntity;

			txtKod.Text = entity.Kod;
			txtHizmetTuruAdi.Text = entity.HizmetTuruAdi;
			txtHizmetTipi.SelectedItem = entity.HizmetTipi.ToName();//hizmet tipinden gelen id seç (16:00)
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new HizmetTuru
			{
				Id = Id,
				Kod = txtKod.Text,
				HizmetTuruAdi = txtHizmetTuruAdi.Text,
				HizmetTipi = txtHizmetTipi.Text.GetEnum<HizmetTipi>(),
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
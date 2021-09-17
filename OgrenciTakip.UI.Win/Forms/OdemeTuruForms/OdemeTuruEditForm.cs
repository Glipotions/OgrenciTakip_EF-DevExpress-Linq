using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
	public partial class OdemeTuruEditForm : BaseEditForm
	{
		public OdemeTuruEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new OdemeTuruBusiness(myDataLayoutControl);
			txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());//ödeme tipi combobaxını doldurur (enum'ın description alır)
			BaseKartTuru = KartTuru.OdemeTuru;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OdemeTuru() : ((OdemeTuruBusiness)Business).Single(FilterFunctions.Filter<OdemeTuru>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((OdemeTuruBusiness)Business).YeniKodVer();
			txtOdemeTuruAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (OdemeTuru)OldEntity;

			txtKod.Text = entity.Kod;
			txtOdemeTuruAdi.Text = entity.OdemeTuruAdi;
			txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();//önemli(combobox)
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new OdemeTuru
			{
				Id = Id,
				Kod = txtKod.Text,
				OdemeTuruAdi = txtOdemeTuruAdi.Text,
				OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),//önemli(combobox)
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
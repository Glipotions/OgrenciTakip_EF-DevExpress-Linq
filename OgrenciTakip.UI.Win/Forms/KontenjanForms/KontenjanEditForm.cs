using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.KontenjanForms
{
	public partial class KontenjanEditForm : BaseEditForm
	{
		public KontenjanEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new KontenjanBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Kontenjan;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Kontenjan() : ((KontenjanBusiness)Business).Single(FilterFunctions.Filter<Kontenjan>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((KontenjanBusiness)Business).YeniKodVer();
			txtKontenjanAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Kontenjan)OldEntity;

			txtKod.Text = entity.Kod;
			txtKontenjanAdi.Text = entity.KontenjanAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Kontenjan
			{
				Id = Id,
				Kod = txtKod.Text,
				KontenjanAdi = txtKontenjanAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
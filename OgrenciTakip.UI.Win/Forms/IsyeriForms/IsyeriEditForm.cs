using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IsyeriForms
{
	public partial class IsyeriEditForm : BaseEditForm
	{
		public IsyeriEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new IsyeriBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Isyeri;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new Isyeri() : ((IsyeriBusiness)Business).Single(FilterFunctions.Filter<Isyeri>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IsyeriBusiness)Business).YeniKodVer();
			txtIsyeriAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Isyeri)OldEntity;

			txtKod.Text = entity.Kod;
			txtIsyeriAdi.Text = entity.IsyeriAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Isyeri
			{
				Id = Id,
				Kod = txtKod.Text,
				IsyeriAdi = txtIsyeriAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
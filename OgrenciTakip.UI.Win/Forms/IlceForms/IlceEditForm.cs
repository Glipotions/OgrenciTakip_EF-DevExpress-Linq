using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.IlceForms
{
	public partial class IlceEditForm : BaseEditForm
	{
		#region Variables
		private readonly long _ilId;
		private readonly string _ilAdi;
		#endregion

		public IlceEditForm(params object[] prm)
		{
			InitializeComponent();
			Business = new IlceBusiness();

			_ilId = (long)prm[0];
			_ilAdi = prm[1].ToString();

			DataLayoutControl = myDataLayoutControl;
			Business = new IlceBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Ilce;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
				new Ilce() : ((IlceBusiness)Business).Single(FilterFunctions.Filter<Ilce>(Id));
			NesneyiKontrollereBagla();
			Text = Text + $" - ( {_ilAdi} ) ";

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IlceBusiness)Business).YeniKodVer(x => x.IlId == _ilId);
			txtIlceAdi.Focus();

		}
		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Ilce)OldEntity;

			txtKod.Text = entity.Kod;
			txtIlceAdi.Text = entity.IlceAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Ilce
			{
				Id = Id,
				Kod = txtKod.Text,
				IlceAdi = txtIlceAdi.Text,
				IlId = _ilId,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected override bool EntityInsert()
		{
			return ((IlceBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
		}

		protected override bool EntityUpdate()
		{
			return ((IlceBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
		}
	}
}
using DevExpress.XtraGrid;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.FiltreForms
{
	public partial class FiltreEditForm : BaseEditForm
	{
		private readonly KartTuru _filtreKartTuru;
		private readonly GridControl _filtreGrid;

		public FiltreEditForm()
		{
			InitializeComponent();
		}

		public FiltreEditForm(params object[] prm)
		{
			InitializeComponent();

			_filtreKartTuru = (KartTuru)prm[0];
			_filtreGrid = (GridControl)prm[1];

			HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnGeriAl };
			ShowItems = new DevExpress.XtraBars.BarItem[] { btnFarkliKaydet, btnUygula };

			DataLayoutControl = myDataLayoutControl;
			Business = new FiltreBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Filtre;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			txtFiltreMetni.SourceControl = _filtreGrid;

			while (true)
			{
				if (BaseIslemTuru == IslemTuru.EntityInsert)
				{
					OldEntity = new Filtre();
					Id = BaseIslemTuru.IdOlustur(OldEntity);
					txtKod.Text = ((FiltreBusiness)Business).YeniKodVer(x => x.KartTuru == _filtreKartTuru);
				}
				else
				{
					OldEntity = ((FiltreBusiness)Business).Single(FilterFunctions.Filter<Filtre>(Id));
					if (OldEntity == null)
					{
						BaseIslemTuru = IslemTuru.EntityInsert;
						continue;
					}
					NesneyiKontrollereBagla();
				}
				break;
			}


		}
		protected override void NesneyiKontrollereBagla()
		{
			var entity = (Filtre)OldEntity;

			txtKod.Text = entity.Kod;
			txtFiltreAdi.Text = entity.FiltreAdi;
			txtFiltreMetni.FilterString = entity.FiltreMetni;

		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Filtre
			{
				Id = Id,
				Kod = txtKod.Text,
				FiltreAdi = txtFiltreAdi.Text,
				FiltreMetni = txtFiltreMetni.FilterString,
				KartTuru = _filtreKartTuru
			};

			ButtonEnabledDurumu();
		}

		protected override bool EntityInsert()
		{
			return ((FiltreBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
		}

		protected override bool EntityUpdate()
		{
			return ((FiltreBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
		}

		protected override void FiltreUygula()
		{
			txtFiltreMetni.Select();
			txtFiltreMetni.ApplyFilter();
		}

		protected internal override void ButtonEnabledDurumu()
		{
			if (!IsLoaded) return;
			GeneralFunctions.ButtonEnabledDurum(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);
		}
	}
}
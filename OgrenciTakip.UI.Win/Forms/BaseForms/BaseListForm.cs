using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.UI.Win.Forms.FiltreForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Show.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
	public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		#region Variables
		private long _filtreId;
		private bool _formSablonKayitEdilecek;
		private bool _tabloSablonKayitEdilecek;
		protected IBaseFormShow FormShow;
		protected IBaseBusiness Business;
		protected KartTuru BaseKartTuru;
		protected ControlNavigator Navigator;
		protected BarItem[] ShowItems;
		protected BarItem[] HideItems;
		protected bool AktifKartlariGoster = true;
		protected internal GridView Tablo;
		protected internal BaseEntity SelectedEntity;
		protected internal bool AktifPasifButonGöster = false;
		protected internal bool MultiSelect;
		protected internal long? SeciliGelecekId;

		#endregion
		public BaseListForm()
		{
			InitializeComponent();
		}

		private void EventsLoad()
		{
			//ButtonEvents
			foreach (BarItem button in ribbonControl.Items)
				button.ItemClick += Button_ItemClick;

			//TableEvents
			Tablo.DoubleClick += Tablo_DoubleClick;
			Tablo.KeyDown += Tablo_KeyDown;
			Tablo.MouseUp += Tablo_MouseUp;
			Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
			Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
			Tablo.EndSorting += Tablo_EndSorting;
			Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
			Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
			Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;

			//FormEvents
			Shown += BaseListForm_Shown;
			Load += BaseListForm_Load;
			FormClosing += BaseListForm_FormClosing;
			LocationChanged += BaseListForm_LocationChanged;
			SizeChanged += BaseListForm_SizeChanged;
		}

		private void ButtonGizleGoster()
		{
			btnSec.Visibility = AktifPasifButonGöster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
			barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
			barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
			btnAktifPasifKartlar.Visibility = AktifPasifButonGöster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

			ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
			HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
		}
		private void SutunGizleGoster()
		{
			throw new NotImplementedException();
		}
		private void SablonKaydet()
		{
			if (_formSablonKayitEdilecek)
				Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

			if (_tabloSablonKayitEdilecek)
				Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
		}
		private void SablonYukle()
		{
			if (IsMdiChild)
				Tablo.TabloSablonYukle(Name + " Tablosu");
			else
			{
				Name.FormSablonYukle(this);
				Tablo.TabloSablonYukle(Name + " TablosuMDI");
			}
		}
		private void EntityDelete()
		{
			var entity = Tablo.GetRow<BaseEntity>();
			if (entity == null) return;
			if (!((IBaseCommonBusiness)Business).Delete(entity)) return;

			Tablo.DeleteSelectedRows();
			Tablo.RowFocus(Tablo.FocusedRowHandle);

		}
		private void SelectEntity()
		{
			if (MultiSelect)
			{

			}
			else
				SelectedEntity = Tablo.GetRow<BaseEntity>();

			DialogResult = DialogResult.OK;
			Close();
		}
		private void FormCaptionAyarla()
		{
			if (btnAktifPasifKartlar == null)
			{
				Listele();
				return;
			}

			if (AktifKartlariGoster == true)
			{
				btnAktifPasifKartlar.Caption = "Pasif Kartlar";
				Tablo.ViewCaption = Text;
			}
			else
			{
				btnAktifPasifKartlar.Caption = "Aktif Kartlar";
				Tablo.ViewCaption = Text + " - Pasif Kartlar";
			}

			Listele();

		}
		private void IslemTuruSec()
		{
			if (!IsMdiChild)
			{
				SelectEntity();
			}
			else
				btnDuzelt.PerformClick();
		}
		private void FiltreSec()
		{
			var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
			if (entity == null) return;

			_filtreId = entity.Id;
			Tablo.ActiveFilterString = entity.FiltreMetni;

		}
		protected void ShowEditFormDefault(long id)
		{
			if (id <= 0) return;
			AktifKartlariGoster = true;
			FormCaptionAyarla();
			Tablo.RowFocus("Id", id);


		}
		protected virtual void DegiskenleriDoldur() { }
		protected virtual void ShowEditForm(long id)
		{
			var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
			ShowEditFormDefault(result);
		}
		protected virtual void Listele() { }
		protected virtual void Yazdir()
		{
			TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
		}
		protected virtual void BagliKartAc() { }
		protected internal void Yukle()
		{
			DegiskenleriDoldur();
			EventsLoad();

			Tablo.OptionsSelection.MultiSelect = MultiSelect;
			Navigator.NavigatableControl = Tablo.GridControl;

			Cursor.Current = Cursors.WaitCursor;
			Listele();
			Cursor.Current = DefaultCursor;

			//Güncellenecek
		}

		private void Button_ItemClick(object sender, ItemClickEventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			if (e.Item == btnGonder)
			{
				var link = (BarSubItemLink)e.Item.Links[0];
				link.Focus();
				link.OpenMenu();
				link.Item.ItemLinks[0].Focus();
			}
			else if (e.Item == btnExcelStandart)
				Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
			else if (e.Item == btnExcelFormatli)
				Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
			else if (e.Item == btnExcelFormatsiz)
				Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption);
			else if (e.Item == btnWordDosyasi)
				Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
			else if (e.Item == btnPdfDosyasi)
				Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
			else if (e.Item == btnTxtDosyasi)
				Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption, Text);
			else if (e.Item == btnYeni)
			{
				ShowEditForm(-1);
			}
			else if (e.Item == btnDuzelt)
				ShowEditForm(Tablo.GetRowId());
			else if (e.Item == btnSil)
			{
				//Yetki Kontrolü
				EntityDelete();
			}
			else if (e.Item == btnSec)
				SelectEntity();
			else if (e.Item == btnYenile)
				Listele();
			else if (e.Item == btnFiltrele)
				FiltreSec();
			else if (e.Item == btnKolonlar)
			{
				if (Tablo.CustomizationForm == null)
					Tablo.ShowCustomization();
				else
					Tablo.HideCustomization();
			}
			else if (e.Item == btnBagliKartlar)
				BagliKartAc();
			else if (e.Item == btnYazdir)
				Yazdir();
			else if (e.Item == btnCikis)
				Close();

			else if (e.Item == btnAktifPasifKartlar)
			{
				AktifKartlariGoster = !AktifKartlariGoster;
				FormCaptionAyarla();
			}

			Cursor.Current = DefaultCursor;
		}
		private void Tablo_DoubleClick(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			IslemTuruSec();
			Cursor.Current = DefaultCursor;
		}
		private void Tablo_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					IslemTuruSec();
					break;
				case Keys.Escape:
					Close();
					break;
			}
		}
		private void Tablo_MouseUp(object sender, MouseEventArgs e)
		{
			e.SagTikMenuGoster(sagTikMenu);
		}
		private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
		{
			_tabloSablonKayitEdilecek = true;
		}
		private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
		{
			_tabloSablonKayitEdilecek = true;
		}
		private void Tablo_EndSorting(object sender, EventArgs e)
		{
			_tabloSablonKayitEdilecek = true;
		}
		private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
		{
			e.ShowFilterEditor = false;
			ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
		}
		private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
				_filtreId = 0;
		}
		private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
		{
			if (!Tablo.OptionsView.ShowFooter) return;
			if (e.Column.Summary.Count > 0)
				e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
		}
		private void BaseListForm_Shown(object sender, EventArgs e)
		{
			Tablo.Focus();
			ButtonGizleGoster();
			//SutunGizleGoster();


			if (IsMdiChild || !SeciliGelecekId.HasValue) return;
			Tablo.RowFocus("Id", SeciliGelecekId);
		}
		private void BaseListForm_Load(object sender, EventArgs e)
		{
			SablonYukle();
		}
		private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SablonKaydet();
		}
		private void BaseListForm_LocationChanged(object sender, EventArgs e)
		{
			if (!IsMdiChild)
				_formSablonKayitEdilecek = true;
		}
		private void BaseListForm_SizeChanged(object sender, EventArgs e)
		{
			if (!IsMdiChild)
				_formSablonKayitEdilecek = true;
		}
	}
}
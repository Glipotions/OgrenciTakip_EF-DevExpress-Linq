using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Interfaces;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.UserControls.Grid;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
	public partial class BaseEditForm : RibbonForm
	{
		#region Variables
		private bool _formSablonKayitEdilecek;
		protected MyDataLayoutControl DataLayoutControl;
		protected MyDataLayoutControl[] DataLayoutControls;
		protected IBaseBusiness Business;
		protected KartTuru BaseKartTuru;
		protected internal IslemTuru BaseIslemTuru;
		protected internal long Id;
		protected internal bool RefreshYapilacak;
		protected BaseEntity OldEntity;
		protected BaseEntity CurrentEntity;
		protected bool IsLoaded;
		protected bool KayitSonrasiFormuKapat = true;
		protected BarItem[] ShowItems;
		protected BarItem[] HideItems;
		protected internal bool RefreshYapilacakMi;
		protected bool FarkliSubeIslemi;
		#endregion

		public BaseEditForm()
		{
			InitializeComponent();
		}

		protected void EventsLoad()
		{
			//ButtonEvents
			foreach (BarItem button in ribbonControl.Items)
				button.ItemClick += Button_ItemClick;

			//FormEvents
			LocationChanged += BaseEditForm_LocationChanged;
			SizeChanged += BaseEditForm_SizeChanged;
			Load += BaseEditForm_Load;
			FormClosing += BaseEditForm_FormClosing;
			Shown += BaseEditForm_Shown;


			void ControlEvents(Control control)
			{
				control.KeyDown += Control_KeyDown;
				control.GotFocus += Control_GotFocus;
				control.Leave += Control_Leave;
				control.Enter += Control_Enter;

				switch (control)
				{
					case FilterControl edt:
						edt.FilterChanged += Control_EditValueChanged;
						break;
					case ComboBoxEdit edt:
						edt.EditValueChanged += Control_EditValueChanged;
						edt.SelectedValueChanged += Control_SelectedValueChanged;
						break;
					case MyButtonEdit edt:
						edt.IdChanged += Control_IdChanged;
						edt.EnabledChange += Control_EnabledChange;
						edt.ButtonClick += Control_ButtonClick;
						edt.DoubleClick += Control_DoubleClick;
						break;
					case BaseEdit edt:
						edt.EditValueChanged += Control_EditValueChanged;
						break;

					case TabPane tab:
						tab.SelectedPageChanged += Control_SelectedPageChanged;
						break;
					case PropertyGridControl pGrd:
						pGrd.CellValueChanged += Control_CellValueChanged;
						pGrd.FocusedRowChanged += Control_FocusedRowChanged;
						break;
				}
			}

			if (DataLayoutControls == null)
			{
				if (DataLayoutControl == null) return;
				foreach (Control ctrl in DataLayoutControl.Controls)
					ControlEvents(ctrl);
			}
			else
				foreach (var layout in DataLayoutControls)
					foreach (Control ctrl in layout.Controls)
						ControlEvents(ctrl);

		}


		private void FarkliKaydet()
		{
			if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onay") != DialogResult.Yes) return;

			BaseIslemTuru = IslemTuru.EntityInsert;
			Yukle();
			if (Kaydet(true))
				Close();
		}
		private void SablonYukle()
		{
			Name.FormSablonYukle(this);
		}
		private void GeriAl()
		{
			if (Messages.HayirSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır\nOnaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
			if (BaseIslemTuru == IslemTuru.EntityUpdate)
				Yukle();
			else
				Close();
		}
		private void ButtonGizleGoster()
		{
			ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
			HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
		}
		private bool Kaydet(bool kapanis)
		{
			bool KayitIslemi()
			{
				Cursor.Current = Cursors.WaitCursor;

				switch (BaseIslemTuru)
				{
					case IslemTuru.EntityInsert:
						if (EntityInsert())
							return KayitSonrasiIslemler();
						break;

					case IslemTuru.EntityUpdate:
						if (EntityUpdate())
							return KayitSonrasiIslemler();
						break;
				}

				bool KayitSonrasiIslemler()
				{
					OldEntity = CurrentEntity;
					RefreshYapilacak = true;
					ButtonEnabledDurumu();

					if (KayitSonrasiFormuKapat)
						Close();
					else
						BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;


					return true;
				}

				return false;
			}

			var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();

			switch (result)
			{
				case DialogResult.Yes:
					return KayitIslemi();

				case DialogResult.No:
					if (kapanis)
						btnKaydet.Enabled = false;
					return true;

				case DialogResult.Cancel:
					return false;
			}

			return false;
		}
		protected void SablonKaydet()
		{
			if (_formSablonKayitEdilecek)
				Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

		}
		public virtual void Giris()
		{
		}
		protected virtual void FiltreUygula() { }
		protected virtual void TaksitOlustur() { }
		protected virtual void BaskiOnizleme() { }
		protected virtual void Yazdir() { }
		protected virtual void SecimYap(object sender) { }
		protected virtual bool EntityInsert()
		{
			return ((IBaseGenelBusiness)Business).Insert(CurrentEntity);
		}
		protected virtual bool EntityUpdate()
		{
			return ((IBaseGenelBusiness)Business).Update(OldEntity, CurrentEntity);
		}
		protected virtual void EntityDelete()
		{
			if (!((IBaseCommonBusiness)Business).Delete(OldEntity)) return;
			RefreshYapilacak = true;
			Close();
		}
		protected virtual void NesneyiKontrollereBagla() { }
		protected virtual void GuncelNesneOlustur() { }
		protected virtual void TabloYukle() { }
		protected virtual void SifreSifirla() { }
		public virtual void Yukle() { }
		protected internal virtual IBaseEntity ReturnEntity() { return null; }
		protected internal virtual void ButtonEnabledDurumu()
		{
			if (!IsLoaded) return;
			GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);
		}
		protected virtual void BagliTabloYukle()
		{
		}
		protected virtual bool BagliTabloKaydet()
		{
			return false;
		}
		protected virtual bool BagliTabloHataliGirisKontrol()
		{
			return false;
		}
		private void Button_ItemClick(object sender, ItemClickEventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			if (e.Item == btnYeni)
			{
				//Yetki kontrolü yapılacak

				BaseIslemTuru = IslemTuru.EntityInsert;
				Yukle();
			}

			else if (e.Item == btnKaydet)
				Kaydet(false);
			else if (e.Item == btnFarkliKaydet)
			{
				//YetkiKontrolü
				FarkliKaydet();
			}
			else if (e.Item == btnGeriAl)
				GeriAl();
			else if (e.Item == btnSil)
			{
				//Yetki Kontrolü Yapılacak
				EntityDelete();
			}

			else if (e.Item == btnSil)
			{
				EntityDelete();
			}

			else if (e.Item == btnUygula)
				FiltreUygula();
			else if (e.Item == btnTaksitOlustur)
				TaksitOlustur();

			else if (e.Item == btnYazdir)
				Yazdir();

			else if (e.Item == btnBaskiOnizleme)
				BaskiOnizleme();
			else if (e.Item == btnSifreSifirla)
				SifreSifirla();

			else if (e.Item == btnCikis)
			{
				Close();
			}

			Cursor.Current = DefaultCursor;
		}

		private void BaseEditForm_LocationChanged(object sender, EventArgs e)
		{
			_formSablonKayitEdilecek = true;
		}
		private void BaseEditForm_SizeChanged(object sender, EventArgs e)
		{
			_formSablonKayitEdilecek = true;
		}
		private void BaseEditForm_Load(object sender, EventArgs e)
		{
			IsLoaded = true;
			GuncelNesneOlustur();
			SablonYukle();
			ButtonGizleGoster();

			//güncelleme yapılacak
		}
		private void Control_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();

			if (sender is MyButtonEdit edt)
				switch (e.KeyCode)
				{
					case Keys.Delete when e.Control && e.Shift:
						edt.Id = null;
						edt.EditValue = null;
						break;

					case Keys.F4:
					case Keys.Down when e.Modifiers == Keys.Alt:
						SecimYap(edt);
						break;


				}
		}
		private void Control_GotFocus(object sender, EventArgs e)
		{
			var type = sender.GetType();

			if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit) || type == typeof(MyColorPickEdit))
			{
				statusBarKisayol.Visibility = BarItemVisibility.Always;
				statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

				statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
				statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
				statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
			}
			else if (sender is IStatusBarAciklama ctrl)
				statusBarAciklama.Caption = ctrl.StatusBarAciklama;

		}
		private void Control_Leave(object sender, EventArgs e)
		{
			statusBarKisayol.Visibility = BarItemVisibility.Never;
			statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
		}
		private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			SecimYap(sender);
		}
		private void Control_DoubleClick(object sender, EventArgs e)
		{
			SecimYap(sender);
		}
		protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
		{
			if (!IsLoaded) return;
			GuncelNesneOlustur();
		}
		protected virtual void Control_Enter(object sender, EventArgs e)
		{
		}
		protected virtual void Control_EditValueChanged(object sender, EventArgs e)
		{
			if (!IsLoaded) return;
			GuncelNesneOlustur();
		}
		protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
		protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SablonKaydet();

			if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

			if (!Kaydet(true))
				e.Cancel = true;
		}
		protected virtual void BaseEditForm_Shown(object sender, EventArgs e)
		{ }
		protected virtual void Control_EnabledChange(object sender, EventArgs e) { }
		protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
		{
		}
		protected virtual void Control_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e){}
		protected virtual void Control_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e){}
	}
}
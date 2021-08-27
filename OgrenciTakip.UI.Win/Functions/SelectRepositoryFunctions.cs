using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.UI.Win.Functions
{
	public static class SelectRepositoryFunctions
    {
        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _butonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;

        private static void RemoveEvent()
        {
            if (_butonEdit == null) return;

            _butonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _butonEdit.KeyDown -= ButtonEdit_KeyDown;
            _butonEdit.DoubleClick -= ButtonEdit_DoubleClick;

            _tablo.KeyDown -= Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _butonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _butonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _butonEdit.KeyDown += ButtonEdit_KeyDown;
            _butonEdit.DoubleClick += ButtonEdit_DoubleClick;

            _tablo.KeyDown += Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmIdColumn, GridColumn prmNameColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _butonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _prmIdColumn = prmIdColumn;
            _prmNameColumn = prmNameColumn;

            _butonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _butonEdit.KeyDown += ButtonEdit_KeyDown;
            _butonEdit.DoubleClick += ButtonEdit_DoubleClick;

            _tablo.KeyDown += Tablo_KeyDown;
        }

        private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void SecimYap()
        {
            switch (_butonEdit.Name)
            {
                case "repositoryYakinlik":
                    {

                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;

				case "repositoryBanka":
					{
						if (!_nameColumn.OptionsColumn.AllowEdit) return;

						var id = _tablo.GetRowCellId(_idColumn);
						var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
						if (entity != null)
						{
							_tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
							_tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
							_navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
						}
					}
					break;

				case "repositoryBankaSube":
					{
						if (!_nameColumn.OptionsColumn.AllowEdit) return;

						var id = _tablo.GetRowCellId(_idColumn);
						var bankaId = _tablo.GetRowCellId(_prmIdColumn);
						var bankaAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

						var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, id, bankaId, bankaAdi);
						if (entity != null)
						{
							_tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
							_tablo.SetFocusedRowCellValue(_nameColumn, entity.SubeAdi);
							_navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
						}
					}
					break;

					//case "repositoryBankaHesap":
					//    {
					//        if (!_nameColumn.OptionsColumn.AllowEdit) return;

					//        var id = _tablo.GetRowCellId(_idColumn);
					//        var odemeTipi = _tablo.GetFocusedRowCellValue("OdemeTipi").ToString().GetEnum<OdemeTipi>();

					//        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, odemeTipi);
					//        if (entity != null)
					//        {
					//            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
					//            _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
					//            _tablo.SetFocusedRowCellValue("BlokeGunSayisi", entity.BlokeGunSayisi);
					//            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					//        }
					//    }
					//    break;

					//case "repositoryIptalNedeni":
					//    {
					//        if (!_nameColumn.OptionsColumn.AllowEdit) return;

					//        var id = _tablo.GetRowCellId(_idColumn);
					//        var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, id);
					//        if (entity != null)
					//        {
					//            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
					//            _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedeniAdi);
					//            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					//        }
					//    }
					//    break;

					//case "repositoryGittigiOkul":
					//    {
					//        if (!_nameColumn.OptionsColumn.AllowEdit) return;

					//        var id = _tablo.GetRowCellId(_idColumn);
					//        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, id);
					//        if (entity != null)
					//        {
					//            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
					//            _tablo.SetFocusedRowCellValue(_nameColumn, entity.OkulAdi);
					//            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					//        }
					//    }
					//    break;

					//case "repositoryHesap":
					//    {
					//        var id = _tablo.GetRowCellId(_idColumn);

					//        switch (_tablo.GetRow<GeriOdemeBilgileriL>().HesapTuru)
					//        {
					//            case GeriOdemeHesapTuru.BankaHesap:
					//                {
					//                    var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.Banka, id, OdemeTipi.Elden);
					//                    if (entity == null) return;

					//                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
					//                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
					//                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					//                    break;
					//                }

					//            case GeriOdemeHesapTuru.Kasa:
					//                {
					//                    var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, id);
					//                    if (entity == null) return;

					//                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
					//                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.KasaAdi);
					//                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					//                    break;
					//                }
					//        }
					//    }
					//    break;
			}
        }
    }
}
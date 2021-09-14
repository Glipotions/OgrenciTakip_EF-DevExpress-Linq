﻿using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System.Drawing;
using System.Drawing.Printing;

namespace OgrenciTakip.UI.Win.Functions
{
	public class TablePrintingFunctions
	{
		private static GridView _tablo;
		private static string _subeAdi;
		private static string _kayitSekli;
		private static string _kayitDurumu;
		private static string _iptalDurumu;
		private static string _p1Baslik;
		private static string _p1Deger;
		private static string _p2Baslik;
		private static string _p2Deger;
		private static PrintableComponentLink _link;
		private static PrintingSystem _ps;
		private static DokumParametreleri _dp;

		//public static void Yazdir(GridView tablo, string raporBaslik, string subeAdi)
		//{
		//	_link = new PrintableComponentLink();
		//	_ps = new PrintingSystem();
		//	_tablo = tablo;
		//	_subeAdi = subeAdi;
		//	_dp = ShowEditForms<TabloDokumParametreleri>.ShowDialogEditForm<DokumParametreleri>(raporBaslik);

		//	RaporDokumu();
		//}

		public static void Yazdir(GridView tablo, string raporBaslik, string subeAdi, string kayitSekli = null, string kayitDurumu = null, string iptalDurumu = null, string p1Baslik = null, string p1Value = null, string p2Baslik = null, string p2Value = null)
		{
			_link = new PrintableComponentLink();
			_ps = new PrintingSystem();
			_tablo = tablo;
			_subeAdi = subeAdi;
			_kayitSekli = kayitSekli;
			_kayitDurumu = kayitSekli;
			_iptalDurumu = iptalDurumu;
			_p1Baslik = p1Baslik;
			_p1Deger = p1Value;
			_p2Baslik = p2Baslik;
			_p2Deger = p2Value;
			_dp = ShowEditForms<TabloDokumParametreleri>.ShowDialogEditForm<DokumParametreleri>(raporBaslik);

			RaporDokumu();
		}

		private static void RaporDokumu()
		{
			BaslikEkle();
			RaporuKagidaSigdir();
			_tablo.OptionsPrint.PrintHorzLines = _dp.YatayCizgileriGoster == EvetHayir.Evet;
			_tablo.OptionsPrint.PrintVertLines = _dp.DikeyCizgileriGoster == EvetHayir.Evet;
			_tablo.OptionsPrint.PrintHeader = _dp.SutunBasliklariniGoster == EvetHayir.Evet;
			_tablo.OptionsView.ShowViewCaption = false;

			_link.Component = _tablo.GridControl;
			_link.PaperKind = PaperKind.Letter;
			_link.Margins = new Margins(59, 59, 115, 48);
			_link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
			_link.CreateDocument(_ps);

			switch (_dp.DokumSekli)
			{
				case DokumSekli.TabloBaskiOnizleme:
					ShowRibbonForms<RaporOnizleme>.ShowForm(true, _ps, _dp.RaporBaslik);
					break;
				case DokumSekli.TabloYazdir:
					for (int i = 0; i < _dp.YazdiralacakAdet; i++)
						_link.Print(_dp.YaziciAdi);
					break;
			}

			_tablo.OptionsView.ShowViewCaption = true;

		}

		private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
		{
			if (_dp.BaslikEkle == EvetHayir.Hayir) return;

			var boldFont = new Font("Tahoma", 7, FontStyle.Bold);
			var regularFont = new Font("Tahoma", 7, FontStyle.Regular);

			var sayfaBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = regularFont,
				PageInfo = PageInfo.NumberOfTotal,
				Format = "Sayfa : {0} / {1}",
				Alignment = BrickAlignment.Far,
				AutoWidth = true
			};
			_ps.Graph.DrawBrick(sayfaBrick, new RectangleF(200, 25, 40, 15));

			var tarihBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = regularFont,
				PageInfo = PageInfo.DateTime,
				Format = "Tarih = {0:dd.MM.yyyy}",
				Alignment = BrickAlignment.Far,
				AutoWidth = true
			};
			_ps.Graph.DrawBrick(tarihBrick, new RectangleF(0, 40, 50, 15));

			var subeBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = boldFont,
				Text = "Şube"
			};
			_ps.Graph.DrawBrick(subeBaslikBrick, new RectangleF(0, 25, 40, 15));

			var subeValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = regularFont,
				Text = ": " + _subeAdi
			};
			_ps.Graph.DrawBrick(subeValueBrick, new RectangleF(55, 25, 500, 15));

			var donemBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = boldFont,
				Text = "Dönem"
			};
			_ps.Graph.DrawBrick(donemBaslikBrick, new RectangleF(0, 40, 40, 15));

			var donemValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
			{
				Font = regularFont,
				Text = $": {AnaForm.DonemAdi}"
			};
			_ps.Graph.DrawBrick(donemValueBrick, new RectangleF(55, 40, 200, 15));

			if (_kayitSekli != null)
			{
				var kayitSekliBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = boldFont,
					Text = "Kayıt Şekli"
				};

				_ps.Graph.DrawBrick(kayitSekliBaslikBrick, new RectangleF(0, 55, 55, 15));

				var kayitSekliValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = regularFont,
					Text = $": {_kayitSekli}"
				};

				_ps.Graph.DrawBrick(kayitSekliValueBrick, new RectangleF(55, 55, 250, 15));
			}

			if (_kayitDurumu != null)
			{
				var kayitDurumuBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = boldFont,
					Text = "Kayıt Durumu"
				};

				_ps.Graph.DrawBrick(kayitDurumuBaslikBrick, new RectangleF(250, 40, 70, 15));

				var kayitDurumuValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = regularFont,
					Text = $": {_kayitDurumu}"
				};

				_ps.Graph.DrawBrick(kayitDurumuValueBrick, new RectangleF(340, 40, 150, 15));
			}

			if (_iptalDurumu != null)
			{
				var iptalDurumuBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = boldFont,
					Text = "İptal Durumu"
				};

				_ps.Graph.DrawBrick(iptalDurumuBaslikBrick, new RectangleF(250, 55, 70, 15));

				var iptalDurumuValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = regularFont,
					Text = $": {_iptalDurumu}"
				};

				_ps.Graph.DrawBrick(iptalDurumuValueBrick, new RectangleF(340, 55, 150, 15));
			}

			if (_p1Baslik != null)
			{
				var BaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = boldFont,
					Text = _p1Baslik
				};

				_ps.Graph.DrawBrick(BaslikBrick, new RectangleF(500, 40, 67, 15));

				var ValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = regularFont,
					Text = $": {_p1Deger}"
				};

				_ps.Graph.DrawBrick(ValueBrick, new RectangleF(567, 40, 150, 15));
			}

			if (_p2Baslik != null)
			{
				var BaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = boldFont,
					Text = _p2Baslik
				};

				_ps.Graph.DrawBrick(BaslikBrick, new RectangleF(250, 55, 90, 15));

				var ValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
				{
					Font = regularFont,
					Text = $": {_p2Deger}"
				};

				_ps.Graph.DrawBrick(ValueBrick, new RectangleF(340, 55, 150, 15));
			}
		}

		private static void RaporuKagidaSigdir()
		{
			YazdirmaYonuAyarla();

			switch (_dp.RaporuKagidaSigdir)
			{
				case RaporuKagidaSigdirmaTuru.SutunlariDaraltarakSigdir:
					_tablo.OptionsPrint.AutoWidth = true;
					break;
				case RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir:
					_tablo.OptionsPrint.AutoWidth = false;
					_ps.Document.AutoFitToPagesWidth = 1;
					break;
				default:
					_tablo.OptionsPrint.AutoWidth = false;
					_ps.Document.ScaleFactor = 1.0f;

					break;
			}
		}

		private static void YazdirmaYonuAyarla()
		{
			switch (_dp.YazdirmaYonu)
			{
				case YazdirmaYonu.Dikey:
					_link.Landscape = false;
					break;
				case YazdirmaYonu.Yatay:
					_link.Landscape = true;
					break;
				case YazdirmaYonu.Otomatik:
					_link.Landscape = OtomatikYazdirma();
					break;
				default:
					break;
			}
		}

		private static bool OtomatikYazdirma()
		{
			const int sayfaGenisligi = 703;
			var tabloSutunGenislikleri = 0;

			for (int i = 0; i < _tablo.Columns.Count; i++)
				if (_tablo.Columns[i].Visible)
					tabloSutunGenislikleri += _tablo.Columns[i].Width;

			return tabloSutunGenislikleri > sayfaGenisligi;
		}

		private static void BaslikEkle()
		{
			if (_dp.BaslikEkle == EvetHayir.Hayir) return;

			var headerArea = new PageHeaderArea();
			headerArea.Content.AddRange(new[] { "", _dp.RaporBaslik, "" });
			headerArea.Font = new Font("Arial Narrow", 10f, FontStyle.Bold);
			headerArea.LineAlignment = BrickAlignment.Far;
			_link.PageHeaderFooter = new PageHeaderFooter(headerArea, null);
		}
	}
}

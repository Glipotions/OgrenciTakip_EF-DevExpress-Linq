﻿using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
	public partial class YabanciDilEditForm : BaseEditForm
	{
		public YabanciDilEditForm()
		{
			InitializeComponent();


			DataLayoutControl = myDataLayoutControl;
			Business = new YabanciDilBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.YabanciDil;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new YabanciDil() : ((YabanciDilBusiness)Business).Single(FilterFunctions.Filter<YabanciDil>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((YabanciDilBusiness)Business).YeniKodVer();
			txtYabanciDilAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (YabanciDil)OldEntity;

			txtKod.Text = entity.Kod;
			txtYabanciDilAdi.Text = entity.YabanciDilAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new YabanciDil
			{
				Id = Id,
				Kod = txtKod.Text,
				YabanciDilAdi = txtYabanciDilAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}

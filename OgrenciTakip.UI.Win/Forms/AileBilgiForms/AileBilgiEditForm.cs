﻿using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
	public partial class AileBilgiEditForm : BaseEditForm
	{
		public AileBilgiEditForm()
		{
			InitializeComponent();

			DataLayoutControl= myDataLayoutControl;
			Business = new AileBilgiBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.AileBilgi;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new AileBilgi() : ((AileBilgiBusiness)Business).Single(FilterFunctions.Filter<AileBilgi>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((AileBilgiBusiness)Business).YeniKodVer();
			txtBilgiAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (AileBilgi)OldEntity;

			txtKod.Text = entity.Kod;
			txtBilgiAdi.Text = entity.BilgiAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new AileBilgi
			{
				Id = Id,
				Kod=txtKod.Text,
				BilgiAdi=txtBilgiAdi.Text,
				Aciklama=txtAciklama.Text,
				Durum=tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}
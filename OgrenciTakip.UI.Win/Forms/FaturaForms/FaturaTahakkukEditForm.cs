using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaTahakkukEditForm : BaseEditForm
    {
        public FaturaTahakkukEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            BaseKartTuru = KartTuru.Fatura;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnSil };
            ShowItems = new BarItem[] { btnYazdir };
            txtKdvSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KdvSekli>());
            txtFaturaAdresi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTuru>());
            KayitSonrasiFormuKapat = false;
        }

        public override void Yukle()
        {
            txtKdvSekli.SelectedItem = KdvSekli.Dahil.ToName();   //seçili gelmesi için
            txtFaturaAdresi.SelectedItem = AdresTuru.EvAdresi.ToName();  //ev adresi seçili gelmesi için
            FaturaDonemiYukle();
            FaturaNoYukle();
            TabloYukle();
        }

        private void FaturaDonemiYukle()
        {
            using (var Business = new FaturaBusiness())
            {
                var list = Business.FaturaDonemList(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                list.ForEach(x => txtFaturaDonemi.Properties.Items.Add(x.Date.ToString("d")));
            }
        }

        private void FaturaNoYukle()
        {
            using (var Business = new FaturaBusiness())
            {
                txtSonFaturaNo.Value = Business.MaxFaturaNo(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                txtFaturaNo.Value = txtSonFaturaNo.Value + 1;
            }
        }

        protected internal override void ButtonEnabledDurumu()
        {
			GeneralFunctions.ButtonEnabledDurum(btnKaydet, btnGeriAl, faturaTahakkukTable.TableValueChanged);
		}

        protected override void TabloYukle()
        {
            faturaTahakkukTable.OwnerForm = this;
            faturaTahakkukTable.Yukle();
        }

        protected override bool EntityUpdate()
        {
            if (!faturaTahakkukTable.Kaydet()) return false;

            faturaTahakkukTable.Yukle();
            FaturaNoYukle();
            return true;
        }

        protected override void Yazdir()
        {
            var source = new List<FaturaR>();

            for (int i = 0; i < faturaTahakkukTable.Tablo.DataRowCount; i++)
            {
                var entity = faturaTahakkukTable.Tablo.GetRow<FaturaPlaniL>(i);
                if (entity == null) return;

                var row = new FaturaR
                {
                    OkulNo = entity.OkulNo,
                    TcKimlikNo = entity.TcKimlikNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    VeliTcKimlikNo = entity.VeliTcKimlikNo,
                    VeliAdi = entity.VeliAdi,
                    VeliSoyadi = entity.VeliSoyadi,
                    VeliYakinlikAdi = entity.VeliYakinlikAdi,
                    VeliMeslekAdi = entity.VeliMeslekAdi,
                    FaturaAdres = entity.FaturaAdres,
                    FaturaAdresIlAdi = entity.FaturaAdresIlAdi,
                    FaturaAdresIlceAdi = entity.FaturaAdresIlceAdi,
                    Aciklama = entity.Aciklama,
                    Tarih = entity.TahakkukTarih,
                    FaturaNo = entity.FaturaNo,
                    Tutar = entity.TahakkukTutar,
                    Indirim = entity.TahakkukIndirimTutar,
                    NetTutar = entity.TahakkukNetTutar,
                    KdvSekli = entity.KdvSekli,
                    KdvOrani = entity.KdvOrani,
                    KdvHaricTutar = entity.KdvHaricTutar,
                    KdvTutari = entity.KdvTutari,
                    ToplamTutar = entity.ToplamTutar,
                    TutarYazi = entity.TutarYazi,
                    Sube = entity.Sube,
                    Donem = entity.Donem,
                };

                source.Add(row);
            }

            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.FaturaDonemRaporlari, source);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtFaturaDonemi) return; //yapılan değişiklik Fatura Dönemi txt sinde değilse işlem yapma

            faturaTahakkukTable.Listele();
            faturaTahakkukTable.Tablo.Focus();

		}
    }
}
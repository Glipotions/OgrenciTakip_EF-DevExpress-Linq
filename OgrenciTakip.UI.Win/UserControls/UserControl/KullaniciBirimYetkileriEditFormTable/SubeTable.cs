using System.Linq;
using System.Windows.Forms;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.Functions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Forms.SubeForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class SubeTable : BaseTablo
    {
        public SubeTable()
        {
            InitializeComponent();

            Business = new KullaniciBirimYetkileriBusiness();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //list filtresinde owner form id'ye göre filtreler
            tablo.GridControl.DataSource = ((KullaniciBirimYetkileriBusiness)Business).List(x => x.KullaniciId == OwnerForm.Id && x.KartTuru == KartTuru.Sube)
                .ToBindingList<KullaniciBirimYetkileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KullaniciBirimYetkileriL>().Select(x => x.SubeId.Value).ToList();

            var entities = ShowListForms<SubeListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true, false)
                .EntityListConvert<SubeL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KullaniciBirimYetkileriL
                {
                    Kod = entity.Kod,
                    SubeAdi = entity.SubeAdi,
                    KartTuru = KartTuru.Sube,
                    KullaniciId = OwnerForm.Id,
                    SubeId = entity.Id,
                    Insert = true
                };

                source.Add(row);
            }

            if (!Kaydet()) return;
            Listele();
            tablo.Focus();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Şube Kartı") != DialogResult.Yes) return;

            tablo.GetRow<IBaseHareketEntity>().Delete = true;     // KullaniciBirimYetkileriL de kullanılabilir
            tablo.RefreshDataSource();

            var rowHandle = tablo.FocusedRowHandle;
            if (!Kaydet()) return;
            Listele();
            tablo.FocusedRowHandle = rowHandle;
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = tablo.DataRowCount > 0;
            btnHareketEkle.Enabled =
                ((KullaniciBirimYetkileriEditForm)OwnerForm).kullaniciTable.Tablo.DataRowCount > 0;

            e.SagTikMenuGoster(popupMenu);
        }
    }
}
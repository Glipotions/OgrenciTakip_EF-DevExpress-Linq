using System;
using System.Windows.Forms;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowEditReports<TForm> where TForm : BaseRapor
    {
        public static void ShowEditReport(KartTuru kartTuru)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
    }
}
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using OgrenciTakip.UI.Win.Interfaces;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyColorPickEdit : ColorPickEdit, IStatusBarKisayol
    {
        public MyColorPickEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
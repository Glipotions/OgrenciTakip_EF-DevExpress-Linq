using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.Business.General
{
    public class PromosyonBusiness : BaseGenelBusiness<Promosyon>, IBaseCommonBusiness
    {
        public PromosyonBusiness() : base(KartTuru.Promosyon)
        {
        }

        public PromosyonBusiness(Control control) : base(control, KartTuru.Promosyon)
        {
        }
    }
}
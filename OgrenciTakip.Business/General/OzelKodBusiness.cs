using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Business.General
{
    public class OzelKodBusiness : BaseGenelBusiness<OzelKod>, IBaseCommonBusiness
    {
        public OzelKodBusiness() : base(KartTuru.OzelKod){}

        public OzelKodBusiness(Control control) : base(control, KartTuru.OzelKod) {}
    }
}
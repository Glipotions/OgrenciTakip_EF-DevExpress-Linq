using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.Business.General
{
    public class DonemBusiness : BaseGenelBusiness<Donem>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public DonemBusiness() : base(KartTuru.Donem)
        {
        }

        public DonemBusiness(Control control) : base(control, KartTuru.Donem)
        {
        }
    }
}
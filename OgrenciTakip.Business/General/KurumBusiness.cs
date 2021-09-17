using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Business.General
{
    public class KurumBusiness : BaseGenelYonetimBusiness<Kurum>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public KurumBusiness() : base(KartTuru.Kurum)
        {
        }

        public KurumBusiness(Control control) : base(control, KartTuru.Kurum)
        {
        }

    }
}
using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Business.General
{
    public class ServisBusiness : BaseGenelBusiness<Servis>, IBaseCommonBusiness
    {
        public ServisBusiness() : base(KartTuru.Servis)
        {
        }

        public ServisBusiness(Control control) : base(control, KartTuru.Servis)
        {
        }
    }
}
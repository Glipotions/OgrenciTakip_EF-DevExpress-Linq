using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Business.General
{
    public class RolBusiness : BaseGenelBusiness<Rol>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public RolBusiness() : base(KartTuru.Rol)
        {
        }

        public RolBusiness(Control control) : base(control, KartTuru.Rol)
        {
        }
    }
}
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
    public class IsyeriBusiness : BaseGenelBusiness<Isyeri>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public IsyeriBusiness() : base(KartTuru.Isyeri) { }

        public IsyeriBusiness(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}
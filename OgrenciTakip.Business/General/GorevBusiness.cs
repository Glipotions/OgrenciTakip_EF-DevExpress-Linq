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
    public class GorevBusiness : BaseGenelBusiness<Gorev>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public GorevBusiness() : base(KartTuru.Gorev) { }

        public GorevBusiness(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}
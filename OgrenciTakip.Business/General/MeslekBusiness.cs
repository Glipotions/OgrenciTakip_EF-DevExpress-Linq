using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class MeslekBusiness : BaseGenelBusiness<Meslek>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public MeslekBusiness() : base(KartTuru.Meslek) { }

		public MeslekBusiness(Control ctrl) : base(ctrl, KartTuru.Meslek) { }
	}
}
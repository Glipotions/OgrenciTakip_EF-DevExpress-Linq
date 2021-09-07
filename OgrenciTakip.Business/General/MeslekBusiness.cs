using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class MeslekBusiness : BaseGenelBusiness<Meslek>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public MeslekBusiness() : base(KartTuru.Meslek) { }

		public MeslekBusiness(Control ctrl) : base(ctrl, KartTuru.Meslek) { }
	}
}
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IndirimTuruBusiness : BaseGenelBusiness<IndirimTuru>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IndirimTuruBusiness() : base(KartTuru.IndirimTuru) { }

		public IndirimTuruBusiness(Control ctrl) : base(ctrl, KartTuru.IndirimTuru) { }
	}
}
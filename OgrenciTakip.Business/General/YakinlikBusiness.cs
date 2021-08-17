using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class YakinlikBusiness : BaseGenelBusiness<Yakinlik>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public YakinlikBusiness() : base(KartTuru.Yakinlik) { }

		public YakinlikBusiness(Control ctrl) : base(ctrl, KartTuru.Yakinlik) { }
	}
}
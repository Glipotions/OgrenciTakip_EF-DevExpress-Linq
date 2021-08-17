using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class YabanciDilBusiness : BaseGenelBusiness<YabanciDil>, IBaseGenelBusiness, IBaseCommonBusiness
	{

		public YabanciDilBusiness() : base(KartTuru.YabanciDil)
		{
		}

		public YabanciDilBusiness(Control ctrl) : base(ctrl, KartTuru.YabanciDil)
		{
		}
	}
}

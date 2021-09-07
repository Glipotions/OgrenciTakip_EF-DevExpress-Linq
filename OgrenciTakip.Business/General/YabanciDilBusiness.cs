using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
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

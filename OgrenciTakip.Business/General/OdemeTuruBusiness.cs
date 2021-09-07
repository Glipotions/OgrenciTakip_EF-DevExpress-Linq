using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class OdemeTuruBusiness : BaseGenelBusiness<OdemeTuru>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public OdemeTuruBusiness() : base(KartTuru.OdemeTuru)
		{
		}

		public OdemeTuruBusiness(Control control) : base(control, KartTuru.OdemeTuru)
		{
		}
	}
}
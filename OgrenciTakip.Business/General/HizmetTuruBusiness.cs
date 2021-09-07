using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class HizmetTuruBusiness : BaseGenelBusiness<HizmetTuru>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public HizmetTuruBusiness() : base(KartTuru.HizmetTuru)
		{
		}

		public HizmetTuruBusiness(Control control) : base(control, KartTuru.HizmetTuru)
		{
		}
	}
}
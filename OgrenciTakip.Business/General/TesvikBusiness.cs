using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class TesvikBusiness : BaseGenelBusiness<Tesvik>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public TesvikBusiness() : base(KartTuru.Tesvik) { }

		public TesvikBusiness(Control ctrl) : base(ctrl, KartTuru.Tesvik) { }
	}
}

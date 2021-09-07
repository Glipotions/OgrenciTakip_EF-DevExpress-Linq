using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class RaporBusiness : BaseGenelBusiness<Rapor>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public RaporBusiness() : base(KartTuru.Rapor) { }

		public RaporBusiness(Control control) : base(control, KartTuru.Rapor) { }

		public override IEnumerable<BaseEntity> List(Expression<Func<Rapor, bool>> filter)
		{
			return BaseList(filter, x => new RaporL
			{
				Id = x.Id,
				Kod = x.Kod,
				RaporAdi = x.RaporAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}
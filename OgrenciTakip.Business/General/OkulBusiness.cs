﻿using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Data.Context;
using OgrenciYazilim.Model.Dto;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class OkulBusiness : BaseBusiness<Okul, OgrenciTakipContext>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public OkulBusiness() { }
		public OkulBusiness(Control ctrl) : base(ctrl) { }

		public BaseEntity Single(Expression<Func<Okul, bool>> filter)
		{
			return BaseSingle(filter, x => new OkulS
			{
				Id = x.Id,
				Kod = x.Kod,
				OkulAdi = x.OkulAdi,
				IlId = x.IlId,
				IlAdi = x.Il.IlAdi,
				IlceId=x.IlceId,
				IlceAdi = x.Ilce.IlceAdi,
				Aciklama = x.Aciklama,
				Durum = x.Durum

			});
		}

		public IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
		{
			return BaseList(filter, x => new OkulL
			{
				Id = x.Id,
				Kod = x.Kod,
				OkulAdi = x.OkulAdi,
				IlAdi = x.Il.IlAdi,
				IlceAdi = x.Ilce.IlceAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}

		public bool Insert(BaseEntity entity)
		{
			return BaseInsert(entity, x => x.Kod == entity.Kod);
		}

		public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
		{
			return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
		}

		public bool Delete(BaseEntity entity)
		{
			return BaseDelete(entity, KartTuru.Okul);
		}

		public string YeniKodVer()
		{
			return BaseYeniKodVer(KartTuru.Okul, x => x.Kod);
		}
	}
}
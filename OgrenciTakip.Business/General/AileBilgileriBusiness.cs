using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Data.Context;
using OgrenciYazilim.Model.Dto;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciTakip.Business.General
{
    public class AileBilgileriBusiness : BaseHareketBusiness<AileBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<AileBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<AileBilgileri, bool>> filter)
        {
            return List(filter, x => new AileBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                AileBilgiId = x.AileBilgiId,
                BilgiAdi = x.AileBilgi.BilgiAdi,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}
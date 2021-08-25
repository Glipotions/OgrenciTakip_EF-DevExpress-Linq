using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using OgrenciYazilim.Data.Context;

namespace OgrenciTakip.Business.General
{
    public class SinavBilgileriBusiness : BaseHareketBusiness<SinavBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<SinavBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SinavBilgileri, bool>> filter)
        {
            return List(filter, x => new SinavBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                SinavAdi = x.SinavAdi,
                PuanTuru = x.PuanTuru,
                Puan = x.Puan,
                Sira = x.Sira,
                Yuzde = x.Yuzde
            }).ToList();
        }
    }
}
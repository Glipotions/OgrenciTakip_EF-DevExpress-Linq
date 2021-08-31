using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using OgrenciYazilim.Data.Context;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.Business.General
{
	public class GeriOdemeBilgileriBusiness : BaseHareketBusiness<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                HesapTuru = x.HesapTuru,
                HesapId = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.KasaId : x.BankaHesapId,
                HesapAdi = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.Kasa.KasaAdi : x.BankaHesap.HesapAdi,
                BankaHesapId = x.BankaHesapId,
                KasaId = x.KasaId,
                Tutar = x.Tutar,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Data.Context;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciTakip.Business.General
{
    public class IletisimBilgileriBusiness : BaseHareketBusiness<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IletisimId = x.IletisimId,
                TcKimlikNo = x.Iletisim.TcKimlikNo,
                Adi = x.Iletisim.Adi,
                Soyadi = x.Iletisim.Soyadi,
                EvTelefonu = x.Iletisim.EvTelefonu,
                IsTel1 = x.Iletisim.IsTelefonu1,
                IsTel2 = x.Iletisim.IsTelefonu2,
                CepTel1 = x.Iletisim.CepTelefonu1,
                CepTel2 = x.Iletisim.CepTelefonu2,
                EvAdres = x.Iletisim.EvAdres,
                EvAdresIlAdi = x.Iletisim.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.Iletisim.EvAdresIlce.IlceAdi,
                IsAdres = x.Iletisim.IsAdres,
                IsAdresIlAdi = x.Iletisim.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.Iletisim.IsAdresIlce.IlceAdi,
                YakinlikId = x.YakinlikId,
                YakinlikAdi = x.Yakinlik.YakinlikAdi,
                MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                FaturaAdresi = x.FaturaAdresi
            }).ToList();
        }
    }
}
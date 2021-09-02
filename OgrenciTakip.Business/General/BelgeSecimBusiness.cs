using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Model.Dto;
using OgrenciYazilim.Model.Entities.Base;
using OgrenciTakip.Common.Enums;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Data.Context;

namespace OgrenciTakip.Business.General
{
	public class BelgeSecimBusiness : BaseHareketBusiness<OdemeBilgileri, OgrenciTakipContext>
    {
        public IEnumerable<BaseEntity> List(Expression<Func<OdemeBilgileri, bool>> filter, MakbuzTuru makbuzTuru, MakbuzHesapTuru makuzHesapTuru, OdemeTipi odemeTipi, long? hesapId, long subeId)
        {
            return List(filter, x => new
            {
                OdemeBilgileri = x,
                x.Tahakkuk,
                Toplamlar = x.MakbuzHareketleri.GroupBy(p => p.OdemeBilgileriId).DefaultIfEmpty().Select(p => new
                {
                    Tahsil = p.Where(z => z.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BlokeCozumu || z.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || z.BelgeDurumu == BelgeDurumu.MahsupEtme || z.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || z.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka || z.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),

                    Iade = p.Where(z => z.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),

                    BelgeDurumu = p.Any() ? p.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu : BelgeDurumu.Portfoyde,

                    SonHareketId = (int?)p.Max(z => z.Id),

                    SonHareketTarihi = (DateTime?)p.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.Tarih,

                    SonHesapId = p.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId ?? z.Makbuz.BankaHesapId ?? z.Makbuz.CariHesapId ?? z.Makbuz.KasaHesapId ?? z.Makbuz.SubeHesapId).FirstOrDefault(),

                    HesapTuru = p.Any() ? p.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.MakbuzHesapTuru : 0,

                    BelgeSubeAdi = p.Any() ? p.OrderByDescending(z => z.Id).FirstOrDefault().EskiSube.SubeAdi : x.Tahakkuk.Sube.SubeAdi,

                    SubeId = !p.Any() ? x.Tahakkuk.SubeId : p.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu == BelgeDurumu.OnayBekliyor ? p.OrderByDescending(z => z.Id).FirstOrDefault().YeniSubeId : p.OrderByDescending(z => z.Id).FirstOrDefault().EskiSubeId,

                    SonIslemYeri = p.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId != null ? z.Makbuz.AvukatHesap.AdiSoyadi : z.Makbuz.BankaHesapId != null ? z.Makbuz.BankaHesap.HesapAdi : z.Makbuz.CariHesapId != null ? z.Makbuz.CariHesap.CariAdi : z.Makbuz.KasaHesapId != null ? z.Makbuz.KasaHesap.KasaAdi : z.Makbuz.SubeHesapId != null ? z.Makbuz.SubeHesap.SubeAdi : null).FirstOrDefault()
                }).FirstOrDefault(),
            }).Where(y => y.Toplamlar.SubeId == subeId).Where(y =>

                    makbuzTuru == MakbuzTuru.AvukataGonderme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.AvukatYoluylaTahsilEtme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.AvukataGonderme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme && y.Toplamlar.SonHesapId == hesapId :

                    makbuzTuru == MakbuzTuru.BankayaTahsileGonderme || makbuzTuru == MakbuzTuru.CiroEtme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.BlokeyeAlma ? y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde && y.OdemeBilgileri.OdemeTipi == odemeTipi :

                    makbuzTuru == MakbuzTuru.BlokeCozumu ? y.Toplamlar.BelgeDurumu == BelgeDurumu.BlokeyeAlma && y.OdemeBilgileri.OdemeTipi == odemeTipi && y.Toplamlar.SonHesapId == hesapId :

                    makbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama ? y.Toplamlar.BelgeDurumu == BelgeDurumu.OnayBekliyor && y.Toplamlar.SonHesapId == hesapId :

                    makbuzTuru == MakbuzTuru.KarsiliksizOlarakIsaretleme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.MahsupEtme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.MusteriyeGeriIade ? y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme :

                    makbuzTuru == MakbuzTuru.OdenmisOlarakIsaretleme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme :

                    makbuzTuru == MakbuzTuru.PortfoyeGeriIade ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme) && y.Toplamlar.HesapTuru == makuzHesapTuru && y.Toplamlar.SonHesapId == hesapId :

                    makbuzTuru == MakbuzTuru.PortfoyeKarsiliksizIade ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.AvukataGonderme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme) && y.Toplamlar.HesapTuru == makuzHesapTuru && y.Toplamlar.SonHesapId == hesapId :

                    makbuzTuru == MakbuzTuru.TahsilEtmeKasa || makbuzTuru == MakbuzTuru.TahsilEtmeBanka ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :

                    makbuzTuru == MakbuzTuru.TahsiliImkansizHaleGelme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade :

                    makbuzTuru == MakbuzTuru.BankaYoluylaTahsilEtme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme || y.Toplamlar.SonHesapId == hesapId : y.Toplamlar.BelgeDurumu == 0

            ).Select(x => new BelgeSecimL
            {
                OdemeBilgileriId = x.OdemeBilgileri.Id,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.Soyadi,
                OgrenciNo = x.Tahakkuk.Ogrenci.Kod,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                OgrenciSubeAdi = x.Tahakkuk.Sube.SubeAdi,
                BelgeSubeAdi = x.Toplamlar.BelgeSubeAdi,
                OdemeTuruAdi = x.OdemeBilgileri.OdemeTuru.OdemeTuruAdi,
                OdemeTipi = x.OdemeBilgileri.OdemeTipi,
                BankaHesapAdi = x.OdemeBilgileri.BankaHesap.HesapAdi,
                TakipNo = x.OdemeBilgileri.TakipNo,
                GirisTarihi = x.OdemeBilgileri.GirisTarihi,
                Vade = x.OdemeBilgileri.Vade,
                HesabaGecisTarihi = x.OdemeBilgileri.HesabaGecisTarihi,
                Tutar = x.OdemeBilgileri.Tutar,
                Tahsil = x.Toplamlar.Tahsil,
                Iade = x.Toplamlar.Iade,
                Kalan = x.OdemeBilgileri.Tutar - (x.Toplamlar.Tahsil + x.Toplamlar.Iade),
                BankaAdi = x.OdemeBilgileri.Banka.BankaAdi,
                BankaSubeAdi = x.OdemeBilgileri.BankaSube.SubeAdi,
                HesapNo = x.OdemeBilgileri.HesapNo,
                BelgeNo = x.OdemeBilgileri.BelgeNo,
                AsilBorclu = x.OdemeBilgileri.AsilBorclu,
                Ciranta = x.OdemeBilgileri.Ciranta,
                Aciklama = x.OdemeBilgileri.Aciklama,
                SonHareketId = x.Toplamlar.SonHareketId,
                SonHareketTarihi = x.Toplamlar.SonHareketTarihi,
                SonIslemYeri = x.Toplamlar.SonIslemYeri,
                BelgeDurumu = x.Toplamlar.BelgeDurumu,
                MakbuzHesapTuru = x.Toplamlar.HesapTuru,
                SubeId = x.Toplamlar.SubeId
            }).OrderBy(x => x.Vade).ToList();
        }
    }
}

//DefaultIfEmpty() null değer gelmez yerine 0 verilir (4/6) 7.video 14:00
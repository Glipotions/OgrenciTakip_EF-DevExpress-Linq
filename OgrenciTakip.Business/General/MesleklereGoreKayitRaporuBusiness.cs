using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Business.General
{
    public class MesleklereGoreKayitRaporuBusiness : BaseBusiness<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<MesleklereGoreKayitRaporL> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,

                x.Sube,

                MeslekId = x.IletisimBilgileri.Where(y => y.Veli).Select(y => y.Iletisim.MeslekId).FirstOrDefault(),

                MeslekAdi = x.IletisimBilgileri.Where(y => y.Veli).Select(y => y.Iletisim.Meslek.MeslekAdi).FirstOrDefault(),

                HizmetBilgileri = x.HizmetBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutHizmet = y.Select(z => z.BrutUcret).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenHizmet = y.Select(z => z.KistDonemDusulenUcret).DefaultIfEmpty(0).Sum(),
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(p => p.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    NetIndirim = y.Select(p => p.NetIndirim).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                OdemeBilgileri = x.OdemeBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    Acik = y.Where(z => z.OdemeTipi == OdemeTipi.Acik).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Cek = y.Where(z => z.OdemeTipi == OdemeTipi.Cek).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Elden = y.Where(z => z.OdemeTipi == OdemeTipi.Elden).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Epos = y.Where(z => z.OdemeTipi == OdemeTipi.Epos).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Ots = y.Where(z => z.OdemeTipi == OdemeTipi.Ots).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Pos = y.Where(z => z.OdemeTipi == OdemeTipi.Pos).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Senet = y.Where(z => z.OdemeTipi == OdemeTipi.Senet).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    ToplamOdeme = y.Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Tahsil = y.Select(z => z.MakbuzHareketleri.Where(p => p.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || p.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || p.BelgeDurumu == BelgeDurumu.BlokeCozumu || p.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || p.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || p.BelgeDurumu == BelgeDurumu.MahsupEtme || p.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || p.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa || p.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),
                    Iade = y.Select(z => z.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty().Sum(),
                    Tahsilde = y.Select(z => z.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.AvukataGonderme || c.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme || c.BelgeDurumu == BelgeDurumu.CiroEtme || c.BelgeDurumu == BelgeDurumu.BlokeyeAlma).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum() - y.Select(z => z.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BlokeCozumu || c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || c.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || c.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                GeriOdemeBilgileri = x.GeriOdemeBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    GeriDonen = y.Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).AsEnumerable().GroupBy(x => new { x.MeslekId, x.Tahakkuk.SubeId }).Select(x => new MesleklereGoreKayitRaporL
            {
                SubeAdi = x.Select(y => y.Tahakkuk.Sube.SubeAdi).FirstOrDefault(),
                MeslekAdi = x.Select(y => y.MeslekAdi).FirstOrDefault() == null ? "Meslek Girilmedi" : x.Select(y => y.MeslekAdi).FirstOrDefault(),
                KayitYenileme = x.Count(y => y.Tahakkuk.KayitSekli == KayitSekli.KayitYenileme),
                YeniKayit = x.Count(y => y.Tahakkuk.KayitSekli == KayitSekli.YeniKayit),
                NakilKayit = x.Count(y => y.Tahakkuk.KayitSekli == KayitSekli.NakilKayit),
                ToplamKayit = x.Count(),
                BrutHizmet = x.Select(y => y.HizmetBilgileri.BrutHizmet).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenHizmet = x.Select(y => y.HizmetBilgileri.KistDonemDusulenHizmet).DefaultIfEmpty(0).Sum(),
                NetHizmet = x.Select(y => y.HizmetBilgileri.NetHizmet).DefaultIfEmpty(0).Sum(),
                BrutIndirim = x.Select(y => y.IndirimBilgileri.BrutIndirim).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenIndirim = x.Select(y => y.IndirimBilgileri.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                NetIndirim = x.Select(y => y.IndirimBilgileri.NetIndirim).DefaultIfEmpty(0).Sum(),
                Acik = x.Select(y => y.OdemeBilgileri.Acik).DefaultIfEmpty(0).Sum(),
                Cek = x.Select(y => y.OdemeBilgileri.Cek).DefaultIfEmpty(0).Sum(),
                Elden = x.Select(y => y.OdemeBilgileri.Elden).DefaultIfEmpty(0).Sum(),
                Epos = x.Select(y => y.OdemeBilgileri.Epos).DefaultIfEmpty(0).Sum(),
                Ots = x.Select(y => y.OdemeBilgileri.Ots).DefaultIfEmpty(0).Sum(),
                Pos = x.Select(y => y.OdemeBilgileri.Pos).DefaultIfEmpty(0).Sum(),
                Senet = x.Select(y => y.OdemeBilgileri.Senet).DefaultIfEmpty(0).Sum(),
                ToplamOdeme = x.Select(y => y.OdemeBilgileri.ToplamOdeme).DefaultIfEmpty(0).Sum(),
                Tahsil = x.Select(y => y.OdemeBilgileri.Tahsil).DefaultIfEmpty(0).Sum(),
                Iade = x.Select(y => y.OdemeBilgileri.Iade).DefaultIfEmpty(0).Sum(),
                Tahsilde = x.Select(y => y.OdemeBilgileri.Tahsilde).DefaultIfEmpty(0).Sum(),
                GeriOdenen = x.Select(y => y.GeriOdemeBilgileri.GeriDonen).DefaultIfEmpty(0).Sum(),
            }).ToList();
        }
    }
}
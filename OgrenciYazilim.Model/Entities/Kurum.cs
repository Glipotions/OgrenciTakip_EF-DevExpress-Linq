﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class Kurum : BaseEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kurum Adı", "txtKurumAdi")]
        public string KurumAdi { get; set; }

        [Required, StringLength(100), ZorunluAlan("Server", "txtServer")]
        public string Server { get; set; }

        public YetkilendirmeTuru YetkilendirmeTuru { get; set; } = YetkilendirmeTuru.SqlServer;

        [Required, StringLength(50), ZorunluAlan("Kullanıcı Adı", "txtKullaniciAdi")]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şifre", "txtSifre")]
        public string Sifre { get; set; }
    }
}
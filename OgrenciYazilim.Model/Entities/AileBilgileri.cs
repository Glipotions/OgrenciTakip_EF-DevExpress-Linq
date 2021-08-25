﻿using System.ComponentModel.DataAnnotations;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciYazilim.Model.Entities
{
    public class AileBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long AileBilgiId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        //vt ilişki
        public AileBilgi AileBilgi { get; set; }
    }
}
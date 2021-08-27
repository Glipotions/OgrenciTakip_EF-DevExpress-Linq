using System;
using System.ComponentModel.DataAnnotations;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciYazilim.Model.Entities
{
    public class BilgiNotlari : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public DateTime Tarih { get; set; }

        [Required, StringLength(1000)]
        public string BilgiNotu { get; set; }
    }
}
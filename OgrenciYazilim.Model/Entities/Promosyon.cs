using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class Promosyon : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Promosyon Adı", "txtPromosyonAdi")]
        public string PromosyonAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }
        public long DonemId { get; set; }

        //veritabanı ilişkisi
        public Sube Sube { get; set; }

        public Donem Donem { get; set; }
    }
}
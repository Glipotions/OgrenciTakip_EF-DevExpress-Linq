using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class IletisimBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long IletisimId { get; set; }
        public long YakinlikId { get; set; }
        public bool Veli { get; set; }
        public AdresTuru? FaturaAdresi { get; set; }

        //vt ilişki
        public Iletisim Iletisim { get; set; }

        public Yakinlik Yakinlik { get; set; }
    }
}
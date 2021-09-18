using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Entities;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KurumBilgileriS : KurumBilgileri
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }
}
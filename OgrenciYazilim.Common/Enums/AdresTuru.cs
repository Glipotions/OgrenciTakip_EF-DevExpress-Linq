using System.ComponentModel;

namespace OgrenciYazilim.Common.Enums
{
    public enum AdresTuru : byte
    {
        [Description("Ev Adresi")]
        EvAdresi = 1,

        [Description("İş Adresi")]
        IsAdresi = 2
    }
}
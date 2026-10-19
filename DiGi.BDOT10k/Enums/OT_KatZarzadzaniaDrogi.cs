using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Management category of a road in the BDOT10k standard (code list <c>OT_KatZarzadzaniaDrogi</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files.</para>
    /// </summary>
    public enum OT_KatZarzadzaniaDrogi
    {
        /// <summary>
        /// National road.
        /// </summary>
        [Description("krajowa")] krajowa,

        /// <summary>
        /// Voivodeship road.
        /// </summary>
        [Description("wojewódzka")] wojewodzka,

        /// <summary>
        /// County road.
        /// </summary>
        [Description("powiatowa")] powiatowa,

        /// <summary>
        /// Municipal road.
        /// </summary>
        [Description("gminna")] gminna,

        /// <summary>
        /// Internal road, outside the public road categories.
        /// </summary>
        [Description("wewnętrzna")] wewnetrzna,
    }
}

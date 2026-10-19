using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Kind of pedestrian or cycle route in the BDOT10k standard (code list <c>OT_RodzajCiaguRuchuPieszego</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files. These follow Annex 3, Table 8 of Dz.U. 2021 poz. 1412, not the UML diagram in Annex 2, which lists different names.</para>
    /// </summary>
    public enum OT_RodzajCiaguRuchuPieszego
    {
        /// <summary>
        /// Alley or promenade.
        /// </summary>
        [Description("aleja lub pasaż")] aleja_lub_pasaz,

        /// <summary>
        /// Footpath.
        /// </summary>
        [Description("ścieżka")] sciezka,

        /// <summary>
        /// Cycle path.
        /// </summary>
        [Description("droga dla rowerów")] droga_dla_rowerow,
    }
}

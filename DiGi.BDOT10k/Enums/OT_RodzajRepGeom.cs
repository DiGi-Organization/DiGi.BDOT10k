using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Kind of geometric representation of a linear object in the BDOT10k standard (code list <c>OT_RodzajRepGeom</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files.</para>
    /// </summary>
    public enum OT_RodzajRepGeom
    {
        /// <summary>
        /// Notional line, e.g. a carriageway crossing a square.
        /// </summary>
        [Description("linia umowna")] linia_umowna,

        /// <summary>
        /// Artificial connector that keeps the network continuous.
        /// </summary>
        [Description("sztuczny łącznik")] sztuczny_lacznik,
    }
}

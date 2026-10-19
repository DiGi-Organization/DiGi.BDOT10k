using DiGi.BDOT10k.Enums;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Carriageway (<c>jezdnia</c>) of the BDOT10k standard: the axis of a single carriageway segment.
    /// <para>Besides the road attributes of <see cref="OT_CharakterystykaDrogi"/>, a carriageway carries the identity of the street it belongs to, from the TERYT register.</para>
    /// </summary>
    public class OT_SKJZ_L : OT_CharakterystykaDrogi
    {
        /// <summary>
        /// Gets or sets the kind of geometric representation.
        /// <para>Nullable although the UML gives it multiplicity 1: in the Geoportal 2025.07 data most carriageways omit it, and a default would mislabel them.</para>
        /// </summary>
        public OT_RodzajRepGeom? cechaGeometrii { get; set; } = null;

        /// <summary>
        /// Gets or sets the TERYT ULIC street identifier.
        /// </summary>
        public string? identyfikatorULIC { get; set; } = null;

        /// <summary>
        /// Gets or sets the TERYT SIMC identifier of the locality the street lies in.
        /// </summary>
        public string? identyfikatorSIMC { get; set; } = null;

        /// <summary>
        /// Gets or sets the street feature from TERYT, e.g. <c>ul.</c> or <c>pl.</c>.
        /// </summary>
        public string? ulicaCecha { get; set; } = null;

        /// <summary>
        /// Gets or sets the first part of the street name from TERYT.
        /// </summary>
        public string? ulicaNazwa1 { get; set; } = null;

        /// <summary>
        /// Gets or sets the second part of the street name from TERYT.
        /// </summary>
        public string? ulicaNazwa2 { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OT_SKJZ_L"/> class.
        /// </summary>
        public OT_SKJZ_L()
        {
        }
    }
}

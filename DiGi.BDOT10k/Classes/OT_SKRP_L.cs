using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Pedestrian or cycle route (<c>ciąg ruchu pieszego lub rowerowego</c>) of the BDOT10k standard: alleys, promenades, footpaths and cycle paths.
    /// <para>Derives directly from <see cref="OT_ObiektTopograficzny"/>, as in Annex 2 to Dz.U. 2021 poz. 1412.</para>
    /// </summary>
    public class OT_SKRP_L : OT_ObiektTopograficzny, IOT_LiniowyObiektGeometryczny
    {
        /// <summary>
        /// Gets or sets the kind of route.
        /// </summary>
        public OT_RodzajCiaguRuchuPieszego? rodzaj { get; set; } = null;

        /// <summary>
        /// Gets or sets the surface material.
        /// </summary>
        public OT_MaterialNawierzchni? materialNawierzchni { get; set; } = null;

        /// <summary>
        /// Gets or sets the position of the route relative to the ground surface.
        /// </summary>
        public OT_PolozenieObiektuSieciTransportowej? polozenie { get; set; } = null;

        /// <summary>
        /// Gets or sets the TERYT SIMC identifier of the locality.
        /// </summary>
        public string? identyfikatorSIMC { get; set; } = null;

        /// <summary>
        /// Gets or sets the TERYT ULIC street identifier.
        /// </summary>
        public string? identyfikatorULIC { get; set; } = null;

        /// <summary>
        /// Gets or sets the proper name of the route.
        /// </summary>
        public string? nazwa { get; set; } = null;

        /// <summary>
        /// Gets or sets the width in metres.
        /// </summary>
        public double? szerokosc { get; set; } = null;

        /// <summary>
        /// Gets or sets the street feature from TERYT, e.g. <c>ul.</c>.
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
        /// Gets or sets the linear geometry of the object.
        /// </summary>
        public AbstractCurve geometria { get; set; } = new Curve();

        /// <summary>
        /// Initializes a new instance of the <see cref="OT_SKRP_L"/> class.
        /// </summary>
        public OT_SKRP_L()
        {
        }
    }
}

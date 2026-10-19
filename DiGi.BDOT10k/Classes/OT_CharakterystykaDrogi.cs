using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Abstract base of the BDOT10k road classes <see cref="OT_SKJZ_L"/> (carriageway) and <see cref="OT_SKDR_L"/> (road), holding the attributes they share.
    /// <para>Mirrors the abstract UML class <c>OT_CharakterystykaDrogi</c> of Annex 2 to Dz.U. 2021 poz. 1412, which derives directly from <c>OT_ObiektTopograficzny</c>. Property names are the GML element names, because the GML parser binds elements to properties by name.</para>
    /// </summary>
    public abstract class OT_CharakterystykaDrogi : OT_ObiektTopograficzny, IOT_LiniowyObiektGeometryczny
    {
        /// <summary>
        /// Gets or sets the management category of the road.
        /// </summary>
        public OT_KatZarzadzaniaDrogi? kategoriaZarzadzania { get; set; } = null;

        /// <summary>
        /// Gets or sets the technical class of the road.
        /// </summary>
        public OT_KlasaDrogi? klasaDrogi { get; set; } = null;

        /// <summary>
        /// Gets or sets the surface material.
        /// </summary>
        public OT_MaterialNawierzchni? materialNawierzchni { get; set; } = null;

        /// <summary>
        /// Gets or sets the proper name of the road, which is not a street name.
        /// </summary>
        public string? nazwaDrogi { get; set; } = null;

        /// <summary>
        /// Gets or sets the number of carriageways of the road.
        /// </summary>
        public int? liczbaJezdniDrogi { get; set; } = null;

        /// <summary>
        /// Gets or sets the position of the road relative to the ground surface.
        /// </summary>
        public OT_PolozenieObiektuSieciTransportowej? polozenie { get; set; } = null;

        /// <summary>
        /// Gets or sets the surface width in metres.
        /// </summary>
        public double? szerokoscNawierzchni { get; set; } = null;

        /// <summary>
        /// Gets or sets the road numbers. A road segment can carry several, e.g. a European and a national number.
        /// </summary>
        public List<string>? numerDrogi { get; set; } = null;

        /// <summary>
        /// Gets or sets the linear geometry of the object.
        /// </summary>
        public AbstractCurve geometria { get; set; } = new Curve();

        /// <summary>
        /// Initializes a new instance of the <see cref="OT_CharakterystykaDrogi"/> class.
        /// </summary>
        public OT_CharakterystykaDrogi()
        {
        }
    }
}

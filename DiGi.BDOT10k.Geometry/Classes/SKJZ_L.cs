using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents a BDOT10k carriageway (<see cref="OT_SKJZ_L"/>) as a linear geometric object.
    /// </summary>
    public class SKJZ_L : LiniowyObiektGeometryczny<OT_SKJZ_L>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SKJZ_L"/> class.
        /// </summary>
        /// <param name="oT_LiniowyObiektGeometryczny">The input data object for the carriageway.</param>
        /// <param name="curveAppearance">The curve appearance of the object.</param>
        public SKJZ_L(OT_SKJZ_L? oT_LiniowyObiektGeometryczny, ICurveAppearance? curveAppearance)
            : base(oT_LiniowyObiektGeometryczny, curveAppearance)
        {
        }

        /// <summary> Gets the technical class of the road. </summary>
        public OT_KlasaDrogi? klasaDrogi
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.klasaDrogi;
            }
        }

        /// <summary> Gets the management category of the road. </summary>
        public OT_KatZarzadzaniaDrogi? kategoriaZarzadzania
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.kategoriaZarzadzania;
            }
        }

        /// <summary> Gets the proper name of the road. </summary>
        public string? nazwaDrogi
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.nazwaDrogi;
            }
        }

        /// <summary> Gets a copy of the road numbers. </summary>
        public List<string>? numerDrogi
        {
            get
            {
                List<string>? numerDrogi_Source = oT_LiniowyObiektGeometryczny?.numerDrogi;
                return numerDrogi_Source == null ? null : [.. numerDrogi_Source];
            }
        }

        /// <summary> Gets the first part of the street name from TERYT. </summary>
        public string? ulicaNazwa1
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.ulicaNazwa1;
            }
        }

        /// <summary> Gets the TERYT ULIC street identifier. </summary>
        public string? identyfikatorULIC
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.identyfikatorULIC;
            }
        }
    }
}

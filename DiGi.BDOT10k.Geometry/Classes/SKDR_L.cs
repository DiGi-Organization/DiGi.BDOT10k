using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents a BDOT10k road axis (<see cref="OT_SKDR_L"/>) as a linear geometric object.
    /// </summary>
    public class SKDR_L : LiniowyObiektGeometryczny<OT_SKDR_L>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SKDR_L"/> class.
        /// </summary>
        /// <param name="oT_LiniowyObiektGeometryczny">The input data object for the road.</param>
        /// <param name="curveAppearance">The curve appearance of the object.</param>
        public SKDR_L(OT_SKDR_L? oT_LiniowyObiektGeometryczny, ICurveAppearance? curveAppearance)
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
    }
}

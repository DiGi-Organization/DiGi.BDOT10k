using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents a BDOT10k pedestrian or cycle route (<see cref="OT_SKRP_L"/>) as a linear geometric object.
    /// </summary>
    public class SKRP_L : LiniowyObiektGeometryczny<OT_SKRP_L>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SKRP_L"/> class.
        /// </summary>
        /// <param name="oT_LiniowyObiektGeometryczny">The input data object for the route.</param>
        /// <param name="curveAppearance">The curve appearance of the object.</param>
        public SKRP_L(OT_SKRP_L? oT_LiniowyObiektGeometryczny, ICurveAppearance? curveAppearance)
            : base(oT_LiniowyObiektGeometryczny, curveAppearance)
        {
        }

        /// <summary> Gets the kind of route. </summary>
        public OT_RodzajCiaguRuchuPieszego? rodzaj
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.rodzaj;
            }
        }

        /// <summary> Gets the proper name of the route. </summary>
        public string? nazwa
        {
            get
            {
                return oT_LiniowyObiektGeometryczny?.nazwa;
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

using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents a BDOT10k administrative unit (<see cref="OT_ADJA_A"/>) as a surface geometric object.
    /// </summary>
    public class ADJA_A : PowierzchniowyObiektGeometryczny<OT_ADJA_A>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADJA_A"/> class.
        /// </summary>
        /// <param name="oT_PowierzchniowyObiektGeometryczny">The input data object for the administrative unit.</param>
        /// <param name="surfaceAppearance">The surface appearance of the object.</param>
        public ADJA_A(OT_ADJA_A? oT_PowierzchniowyObiektGeometryczny, ISurfaceAppearance? surfaceAppearance)
            : base(oT_PowierzchniowyObiektGeometryczny, surfaceAppearance)
        {
        }
    }
}

using DiGi.BDOT10k.Geometry.Interfaces;
using DiGi.BDOT10k.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Classes;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents an abstract linear geometric object in the BDOT10k standard, carrying its geometry as a <see cref="Polyline2D"/>.
    /// <para>The linear counterpart of <see cref="PowierzchniowyObiektGeometryczny{T}"/>. The geometry is converted by <see cref="Convert.ToDiGi(GML.Classes.AbstractCurve?)"/>, so it is <see langword="null"/> when the source curve cannot be represented.</para>
    /// </summary>
    /// <typeparam name="T">The type of the input data object implementing the <see cref="IOT_LiniowyObiektGeometryczny"/> interface.</typeparam>
    public abstract class LiniowyObiektGeometryczny<T> : VisualCurve2D<Polyline2D>, IObiektGeometryczny<Polyline2D, ICurveAppearance> where T : IOT_LiniowyObiektGeometryczny
    {
        /// <summary>
        /// The input data object, held as a private clone.
        /// </summary>
        protected T? oT_LiniowyObiektGeometryczny;

        private double length = double.NaN;
        private BoundingBox2D? boundingBox2D = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LiniowyObiektGeometryczny{T}"/> class.
        /// </summary>
        /// <param name="oT_LiniowyObiektGeometryczny">The input data object containing the linear geometry.</param>
        /// <param name="curveAppearance">The curve appearance of the object.</param>
        public LiniowyObiektGeometryczny(T? oT_LiniowyObiektGeometryczny, ICurveAppearance? curveAppearance)
            : base(Convert.ToDiGi(oT_LiniowyObiektGeometryczny?.geometria), curveAppearance)
        {
            this.oT_LiniowyObiektGeometryczny = GML.Query.Clone(oT_LiniowyObiektGeometryczny);
        }

        /// <summary> Gets a clone of the input data object associated with this geometric object. </summary>
        public T? OT_LiniowyObiektGeometryczny
        {
            get
            {
                return GML.Query.Clone(oT_LiniowyObiektGeometryczny);
            }
        }

        /// <summary>
        /// Gets the type of the input data object associated with this geometric object.
        /// </summary>
        /// <returns>The type of the input data object, or <see langword="null"/> if the object is not assigned.</returns>
        public System.Type? GetUnderlyingType()
        {
            return oT_LiniowyObiektGeometryczny?.GetType();
        }

        /// <summary> Gets the length of the geometric object, or <see cref="double.NaN"/> when it has no geometry. </summary>
        public double Length
        {
            get
            {
                if (double.IsNaN(length) && Geometry != null)
                {
                    length = Geometry.Length;
                }

                return length;
            }
        }

        /// <summary> Gets the bounding box of the object in 2D space. </summary>
        public BoundingBox2D? BoundingBox2D
        {
            get
            {
                if (boundingBox2D == null && Geometry != null)
                {
                    boundingBox2D = Geometry.GetBoundingBox();
                }

                return boundingBox2D == null ? null : new BoundingBox2D(boundingBox2D);
            }
        }
    }
}

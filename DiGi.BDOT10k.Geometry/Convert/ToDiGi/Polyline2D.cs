using DiGi.Geometry.Planar.Classes;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a GML curve to a <see cref="Polyline2D"/>.
        /// <para>BDOT10k encodes every linear geometry as a <see cref="Curve"/> of <see cref="LineStringSegment"/>s with 2D coordinates. Segments are concatenated in order. The point a segment shares with the previous one, and any other point repeating its predecessor, is removed by <see cref="DiGi.Geometry.Planar.Create.Polyline2D(IEnumerable{Point2D?}?, double)"/>, which also rejects a result with fewer than two distinct points.</para>
        /// </summary>
        /// <param name="abstractCurve">The GML curve to convert.</param>
        /// <returns>The <see cref="Polyline2D"/>; or <see langword="null"/> when the input is <see langword="null"/>, is not a <see cref="Curve"/>, holds a segment that is not a <see cref="LineStringSegment"/>, holds an empty or odd-length coordinate list, or collapses to fewer than two distinct points.</returns>
        public static Polyline2D? ToDiGi(this AbstractCurve? abstractCurve)
        {
            if (abstractCurve is not Curve curve || curve.segments == null || curve.segments.Count == 0)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            foreach (AbstractCurveSegment abstractCurveSegment in curve.segments)
            {
                if (abstractCurveSegment is not LineStringSegment lineStringSegment)
                {
                    return null;
                }

                List<double> values = lineStringSegment.posList;
                if (values == null || values.Count == 0 || values.Count % 2 != 0)
                {
                    return null;
                }

                for (int i = 0; i < values.Count; i += 2)
                {
                    point2Ds.Add(new Point2D(values[i], values[i + 1]));
                }
            }

            return DiGi.Geometry.Planar.Create.Polyline2D(point2Ds);
        }
    }
}

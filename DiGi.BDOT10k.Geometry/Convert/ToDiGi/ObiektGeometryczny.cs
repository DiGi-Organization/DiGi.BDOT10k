using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Interfaces;
using DiGi.BDOT10k.Geometry.Classes;
using DiGi.BDOT10k.Geometry.Interfaces;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a BDOT10k object of the transfer format (IOT) to its DiGi geometric object.
        /// <para>An unsupported class returns <see langword="null"/> instead of throwing. <see cref="Modify.Load(SlownikObiektowGeometrycznych, GML.Classes.FeatureCollection)"/> calls this for every feature member, so a single class without a converter would otherwise abort the load of a whole file.</para>
        /// </summary>
        /// <param name="oT_ObiektGeometryczny">The BDOT10k object to convert.</param>
        /// <returns>The DiGi geometric object; or <see langword="null"/> when the input is <see langword="null"/> or its class is not supported.</returns>
        public static IObiektGeometryczny? ToDiGi(this IOT_ObiektGeometryczny? oT_ObiektGeometryczny)
        {
            if (oT_ObiektGeometryczny == null)
            {
                return null;
            }

            if (oT_ObiektGeometryczny is OT_ADMS_A oT_ADMS_A)
            {
                return new ADMS_A(oT_ADMS_A, null);
            }
            else if (oT_ObiektGeometryczny is OT_BUBD_A oT_BUBD_A)
            {
                return new BUBD_A(oT_BUBD_A, null);
            }
            else if (oT_ObiektGeometryczny is OT_ADJA_A oT_ADJA_A)
            {
                return new ADJA_A(oT_ADJA_A, null);
            }
            else if (oT_ObiektGeometryczny is OT_SKJZ_L oT_SKJZ_L)
            {
                return new SKJZ_L(oT_SKJZ_L, null);
            }
            else if (oT_ObiektGeometryczny is OT_SKDR_L oT_SKDR_L)
            {
                return new SKDR_L(oT_SKDR_L, null);
            }
            else if (oT_ObiektGeometryczny is OT_SKRP_L oT_SKRP_L)
            {
                return new SKRP_L(oT_SKRP_L, null);
            }

            return null;
        }
    }
}
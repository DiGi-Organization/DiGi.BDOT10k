using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Interfaces
{
    /// <summary>
    /// Linear geometric object of the BDOT10k data model (class code suffix <c>_L</c>), whose geometry is a GML curve.
    /// <para>BDOT10k files encode every linear geometry as a <see cref="Curve"/> holding <see cref="LineStringSegment"/>s.</para>
    /// </summary>
    public interface IOT_LiniowyObiektGeometryczny : IOT_ObiektGeometryczny<AbstractCurve>
    {
    }
}

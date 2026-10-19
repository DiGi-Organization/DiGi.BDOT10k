using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Position of a transport network object relative to the ground surface in the BDOT10k standard (code list <c>OT_PolozenieObiektuSieciTransportowej</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files. Levels 1 to 4 apply to bridges, viaducts and flyovers, 4 being the highest.</para>
    /// </summary>
    public enum OT_PolozenieObiektuSieciTransportowej
    {
        /// <summary>
        /// Below the ground surface (tunnel).
        /// </summary>
        [Description("pod powierzchnią gruntu")] pod_powierzchnia_gruntu,

        /// <summary>
        /// On the ground surface.
        /// </summary>
        [Description("na powierzchni gruntu")] na_powierzchni_gruntu,

        /// <summary>
        /// Above the ground surface, level 1.
        /// </summary>
        [Description("ponad powierzchnią gruntu poziom 1")] ponad_powierzchnia_gruntu_poziom_1,

        /// <summary>
        /// Above the ground surface, level 2.
        /// </summary>
        [Description("ponad powierzchnią gruntu poziom 2")] ponad_powierzchnia_gruntu_poziom_2,

        /// <summary>
        /// Above the ground surface, level 3.
        /// </summary>
        [Description("ponad powierzchnią gruntu poziom 3")] ponad_powierzchnia_gruntu_poziom_3,

        /// <summary>
        /// Above the ground surface, level 4.
        /// </summary>
        [Description("ponad powierzchnią gruntu poziom 4")] ponad_powierzchnia_gruntu_poziom_4,
    }
}

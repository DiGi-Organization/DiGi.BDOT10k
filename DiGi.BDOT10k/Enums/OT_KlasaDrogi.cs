using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Technical class of a road in the BDOT10k standard (code list <c>OT_KlasaDrogi</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files, which spells the GP class "przyśpieszonego".</para>
    /// </summary>
    public enum OT_KlasaDrogi
    {
        /// <summary>
        /// Motorway (class A).
        /// </summary>
        [Description("autostrada")] autostrada,

        /// <summary>
        /// Expressway (class S).
        /// </summary>
        [Description("droga ekspresowa")] droga_ekspresowa,

        /// <summary>
        /// Main road with accelerated traffic (class GP).
        /// </summary>
        [Description("droga główna ruchu przyśpieszonego")] droga_glowna_ruchu_przyspieszonego,

        /// <summary>
        /// Main road (class G).
        /// </summary>
        [Description("droga główna")] droga_glowna,

        /// <summary>
        /// Collector road (class Z).
        /// </summary>
        [Description("droga zbiorcza")] droga_zbiorcza,

        /// <summary>
        /// Local road (class L).
        /// </summary>
        [Description("droga lokalna")] droga_lokalna,

        /// <summary>
        /// Access road (class D).
        /// </summary>
        [Description("droga dojazdowa")] droga_dojazdowa,

        /// <summary>
        /// Internal road (class I).
        /// </summary>
        [Description("droga wewnętrzna")] droga_wewnetrzna,
    }
}

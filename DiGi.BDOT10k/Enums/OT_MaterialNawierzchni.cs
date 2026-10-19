using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Surface material of a road, carriageway or path in the BDOT10k standard (code list <c>OT_MaterialNawierzchni</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the exact value written in BDOT10k GML files.</para>
    /// </summary>
    public enum OT_MaterialNawierzchni
    {
        /// <summary>
        /// Concrete.
        /// </summary>
        [Description("beton")] beton,

        /// <summary>
        /// Cobblestone.
        /// </summary>
        [Description("bruk")] bruk,

        /// <summary>
        /// Natural ground (unpaved).
        /// </summary>
        [Description("grunt naturalny")] grunt_naturalny,

        /// <summary>
        /// Stone setts.
        /// </summary>
        [Description("kostka kamienna")] kostka_kamienna,

        /// <summary>
        /// Precast paving blocks.
        /// </summary>
        [Description("kostka prefabrykowana")] kostka_prefabrykowana,

        /// <summary>
        /// Bituminous mix (asphalt).
        /// </summary>
        [Description("masa bitumiczna")] masa_bitumiczna,

        /// <summary>
        /// Concrete slabs.
        /// </summary>
        [Description("płyty betonowe")] plyty_betonowe,

        /// <summary>
        /// Gravel.
        /// </summary>
        [Description("żwir")] zwir,

        /// <summary>
        /// Crushed stone.
        /// </summary>
        [Description("tłuczeń")] tluczen,

        /// <summary>
        /// Other material.
        /// </summary>
        [Description("inny")] inny,
    }
}

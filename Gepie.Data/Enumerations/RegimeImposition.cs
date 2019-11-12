using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Régime d'imposition")]
    public enum RegimeImposition : sbyte
    {
        [Description("Régime synthétique")]
        Synthetique = 1,
        [Description("Régime réel simplifié")]
        ReelSimplifie = 2,
        [Description("Régime réel normal")]
        ReelNormal = 3,
        // Todo Verify enumeration
    }
}
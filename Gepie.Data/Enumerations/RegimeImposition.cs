using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Régime d'imposition")]
    public enum RegimeImposition : sbyte
    {
        [Description("Réel normal d'impôsition (RSI)")]
        RNI = 1,
        [Description("Réel simplifié d'impôsition (RSI)")]
        RSI = 2,
        [Description("Taxe forfaitaire")]
        TF = 3,
        [Description("Impôt synthétique")]
        IS = 4,
    }
}
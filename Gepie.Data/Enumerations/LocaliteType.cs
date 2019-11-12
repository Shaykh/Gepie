using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    
    [DisplayName("Type de Localité")]
    public enum LocaliteType : sbyte
    {
        [Description("Sous-Préfecture")]
        SousPrefecture = 1,
        [Description("Commune")]
        Commune = 2,
        [Description("Village")]
        Village = 3
    }
}
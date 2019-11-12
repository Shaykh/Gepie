using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    public enum Trimestre : sbyte
    {
        [Description("Premier trimestre")]
        Trimestre1 = 1,
        [Description("Deuxième trimestre")]
        Trimestre2 = 2,
        [Description("Troisième trimestre")]
        Trimestre3 = 3,
        [Description("Quatrième trimestre")]
        Trimestre4 = 4,
    }
}
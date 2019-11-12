using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Etape de traitement")]
    public enum EtatTraitementFacture : sbyte
    {
        [Description("Nouveau")]
        Service = 1,
    }
}
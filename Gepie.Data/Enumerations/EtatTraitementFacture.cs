using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Étape de traitement")]
    public enum EtatTraitementFacture : sbyte
    {
        [Description("Nouveau")]
        Nouveau = 1,
        // Todo Clomplete enumeration
    }
}
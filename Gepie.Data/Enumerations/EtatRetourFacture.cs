using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Étape de retour")]
    public enum EtatRetourFacture : sbyte
    {
        [Description("Rejeté")]
        Rejete = -3,
        [Description("Retourné")]
        Retourne = -4
    }
}
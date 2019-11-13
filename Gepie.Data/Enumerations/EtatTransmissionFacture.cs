using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Étape de transmission")]
    public enum EtatTransmissionFacture : sbyte
    {
        [Description("Nouveau")]
        Nouveau = 0,
        [Description("Transmis")]
        Transmis = 1,
        [Description("Réceptionné")]
        Receptionne = 2,
        [Description("Conforme")]
        Conforme = 3,
        [Description("Contrôle terminé")]
        ControleTermine = 4,
        [Description("Rejeté")]
        Rejete = -3,
        [Description("Retourné")]
        Retourne = -4
    }
}
using System.ComponentModel;

namespace Gepie.Data.Enumerations
{
    [DisplayName("Étape de traitement")]
    public enum EtatTraitementFacture : sbyte
    {
        [Description("Enregistrement")]
        Enregistrement = 0,
        [Description("Transmission")]
        Transmission = 1,
        [Description("Réception")]
        Reception = 2,
        [Description("Rejet")]
        Rejet = -3,
        [Description("Conforme")]
        Conforme = 3,
        [Description("Engagement")]
        Engagement = 4,
        [Description("Ordonnancement")]
        Ordonnancement = 5,
        [Description("Rejet Définitif")]
        RejetDefinitif = -6,
        [Description("Paiement")]
        Paiement = 6
    }
}
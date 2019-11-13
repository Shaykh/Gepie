using System.ComponentModel;

namespace Gepie.Data
{
    [DisplayName("Objet de Facture")]
    public enum ObjetFacture : sbyte
    {
        [Description("Loyer")]
        Loyer = 1,
        [Description("Caution")]
        Caution = 2,
        [Description("Droits d'enregistrement")]
        DroitsEnregistrement = 3,
        [Description("Renouvellement d'enregistrement")]
        RenouvellementEnregistrement = 4,
        [Description("Frais d'agence")]
        FraisAgence = 5,
        [Description("Charge Locative")]
        ChargeLocative = 6  
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gepie.Data
{
    public class Paiement : Entite
    {
        public long Id { get; set; }
        [DisplayName("Numéro de virement")]
        public string NumeroVirement { get; set; }
        [Required]
        [DisplayName("Référence")]
        public string Reference { get; set; }
        [DisplayName("Montant Payé")]
        public decimal MontantPaye { get; set; }
        public System.DateTime DateDeVirement { get; set; }

        public virtual Facture Facture { get; set; }
    }
}
namespace Gepie.Data
{
    public class Paiement : Entite
    {
        public long PaiementID { get; set; }
        public string NumeroVirement { get; set; }
        public string Reference { get; set; }
        public decimal MontantPaye { get; set; }
        public System.DateTime DateVirement { get; set; }

        public virtual Facture Facture { get; set; }
    }
}
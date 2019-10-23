namespace Gepie.Data
{
    public class RetourFacture : Entite
    {
        public long RetourFactureID { get; set; }

        public Retour Retour { get; set; }
        public Facture Facture { get; set; }
    }
}
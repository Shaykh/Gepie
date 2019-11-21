namespace Gepie.Data
{
    public class RetourFacture : Entite
    {
        public long Id { get; set; }

        public RetourDeFacture Retour { get; set; }
        public Facture Facture { get; set; }
    }
}
namespace Gepie.Data
{
    public class TransmissionFacture : Entite
    {
        public long Id { get; set; }

        public Facture Facture { get; set; }
        public Transmission Transmission { get; set; }
    }
}
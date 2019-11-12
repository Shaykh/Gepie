namespace Gepie.Data
{
    public class TransmissionFacture : Entite
    {
        public long FactureID { get; set; }
        public long TransmissionID { get; set; }

        public Facture Facture { get; set; }
        public Transmission Transmission { get; set; }
    }
}
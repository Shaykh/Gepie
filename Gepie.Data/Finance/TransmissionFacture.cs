namespace Gepie.Data
{
    public class TransmissionFacture : Entite
    {
        public long FactureID { get; set; }
        public long TransmissionID { get; set; }
        
        public virtual Facture Facture { get; set; }
        public virtual Transmission Transmission { get; set; }
    }
}
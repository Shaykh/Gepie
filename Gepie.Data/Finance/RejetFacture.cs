namespace Gepie.Data
{
    public class RejetFacture : Entite
    {
        public long RejetFactureID { get; set; }
        public System.DateTime DateRejet { get; set; }
        public string MotifRejetDefinitif { get; set; }

        public Facture Facture { get; set; }
    }
}
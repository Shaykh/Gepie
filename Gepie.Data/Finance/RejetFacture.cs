using System.ComponentModel;

namespace Gepie.Data
{
    public class RejetFacture : Entite
    {
        public long Id { get; set; }
        public System.DateTime DateDeRejet { get; set; }
        [DisplayName("Motif de rejet définitif")]
        public string MotifRejetDefinitif { get; set; }

        public Facture Facture { get; set; }
    }
}
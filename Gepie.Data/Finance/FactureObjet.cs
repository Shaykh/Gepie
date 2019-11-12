using System.Collections.Generic;
using System.ComponentModel;

namespace Gepie.Data
{
    public class FactureObjet : Entite
    {
        public short Id { get; set; }
        [DisplayName("Libellé")]
        public string Libelle { get; set; }

        public ICollection<Facture> Factures { get; set; }

        public FactureObjet()
        {
            this.Factures = new HashSet<Facture>();
        }
    }
}
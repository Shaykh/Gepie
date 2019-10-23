using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Retour : Entite
    {
        public long RetourFactureID { get; set; }
        public string Reference { get; set; }
        public DateTime DateEdition { get; set; }
        public DateTime DateRetour { get; set; }
        public byte Etat { get; set; }

        public ICollection<RetourFacture> Factures { get; set; }

        public Retour()
        {
            this.Factures = new HashSet<RetourFacture>();
        }
    }
}
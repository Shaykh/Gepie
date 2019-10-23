using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class FactureObjet : Entite
    {
        public short ObjetID { get; set; }  
        public string Libelle { get; set; } 
        public ICollection<Facture> Factures { get; set; }

        public FactureObjet()
        {
            this.Factures = new HashSet<Facture>();
        }
    }
}
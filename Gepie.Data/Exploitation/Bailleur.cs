using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Bailleur : Entite
    {
        public long BailleurID { get; set; }
        public string Code { get; set; }
        public string Adresse { get; set; }
        public string ContactPrincipal { get; set; }
        public string ContactSecondaire { get; set; }
        public string NumeroCompteContribuable { get; set; }

        public CompteBancaire CompteBancaire { get; set; }

        public virtual ICollection<Fichier> Fichiers { get; set; }
        public virtual ICollection<BienImmobilier> Biens { get; set; }

        public Bailleur()
        {
            this.Fichiers = new HashSet<BailleurFichier>();
            this.Biens = new HashSet<BienImmobilier>();
        }
    }
}

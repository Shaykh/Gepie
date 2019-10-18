using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Bailleur : Entite
    {
        public long BailleurID { get; set; }
        public string CodeBailleur { get; set; }
        public string Adresse { get; set; }
        public string ContactPrincipal { get; set; }
        public string ContactSecondaire { get; set; }
        public string NumeroCompteContribuable { get; set; }

        public CompteBancaire CompteBancaire { get; set; }

        public virtual ICollection<BailleurFichier> Fichiers { get; set; }
        public virtual ICollection<Batiment> Batiments { get; set; }

        public Bailleur()
        {
            this.Fichiers = new HashSet<BailleurFichier>();
            this.Batiments = new HashSet<Batiment>();
        }
    }
}

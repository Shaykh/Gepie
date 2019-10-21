using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class BienImmobilier
    {
        public long BienImmobilierID { get; set; }
        public string Code { get; set; }
        public string Localisation { get; set; }
        public decimal SuperficieBatie { get; set; }
        public short NombrePieces { get; set; }
        public string CoordonneesGeo { get; set; }
        public string Description { get; set; }
        public byte? Usage { get; set; }

        public virtual Bailleur Bailleur { get; set; }
        public virtual Localite Localite { get; set; } 
        public virtual ICollection<Fichier> Fichiers { get; set; }
        public virtual ICollection<ContratBail> Contrats { get; set; }

        public BienImmobilier()
        {
            this.Fichiers = new HashSet<BienFichier>();
            this.Contrats = new HashSet<ContratBail>();
        }
    }
}
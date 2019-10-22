using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Banque : Entite
    {
        public short BanqueID { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<CompteBancaire> CompteBancaires { get; set; }

        public Banque()
        {
            this.CompteBancaires = new HashSet<CompteBancaire>();
        }
    }
}
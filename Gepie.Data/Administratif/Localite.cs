using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Localite : DecoupageGeographique
    {
        public int LocaliteID { get; set; }
        public virtual ICollection<BienImmobilier> Biens { get; set; }
        public virtual Departement Departement { get; set; }

        public Localite()
        {
            this.Biens = new HashSet<BienImmobilier>();
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel;
using Gepie.Data.Enumerations;

namespace Gepie.Data
{
    [DisplayName("Localité")]
    public class Localite : DecoupageGeographique
    {
        public LocaliteType LocaliteType { get; set; }

        public virtual ICollection<BienImmobilier> Biens { get; set; }
        public Departement Departement { get; set; }

        public Localite()
        {
            this.Biens = new HashSet<BienImmobilier>();
        }
    }
}
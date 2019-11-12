using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gepie.Data
{
    [DisplayName("Département")]
    public class Departement : DecoupageGeographique
    {
        public virtual ICollection<Localite> Localites { get; set; }
        public virtual Region Region { get; set; }

        public Departement()
        {
            this.Localites = new HashSet<Localite>();
        }

    }
}
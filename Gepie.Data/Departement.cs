using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Departement : DecoupageGeographique
    {
        public short DepartementID { get; set; }
        public virtual ICollection<Localite> Localites { get; set; }
        public virtual Region Region { get; set; }

        public Departement()
        {
            this.Localites = new HashSet<Localite>();
        }

    }
}
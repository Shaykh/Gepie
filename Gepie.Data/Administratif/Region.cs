using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Region : DecoupageGeographique
    {
        public short RegionID { get; set; }
        public ICollection<Departement> Departements { get; set; }
        public Zone Zone { get; set; }

        public Region()
        {
            this.Departements = new HashSet<Departement>();
        }
    }
}
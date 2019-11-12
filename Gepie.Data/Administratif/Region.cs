using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gepie.Data
{
    [DisplayName("Région")]
    public class Region : DecoupageGeographique
    {
        [DisplayName("Est District")]
        public bool estDistrict { get;set; }

        public ICollection<Departement> Departements { get; set; }
        public Zone Zone { get; set; }

        public Region()
        {
            this.Departements = new HashSet<Departement>();
        }
    }
}
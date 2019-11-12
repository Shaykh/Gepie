using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gepie.Data
{
    [DisplayName("Zone administrative")]
    public class Zone : DecoupageGeographique
    {
        public ICollection<Region> Regions { get; set; }

        public Zone()
        {
            this.Regions = new HashSet<Region>();
        }
    }
}
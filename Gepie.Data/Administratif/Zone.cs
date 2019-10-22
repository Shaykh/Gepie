using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Zone : DecoupageGeographique
    {
        public short ZoneID { get; set; }
        public ICollection<Region> Regions { get; set; }

        public Zone()
        {
            this.Regions = new HashSet<Region>();
        }
    }
}
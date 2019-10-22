using System;

namespace Gepie.Data
{
    public class District : Region
    {
        public short DistrictID { get; set; }
        public virtual ICollection<Localite> Localites { get; set; }

        public District()
        {
            this.Localites = new Hashset<Localite>();
        }
    }
}
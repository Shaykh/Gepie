using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Occupant : Entite
    {
        public long OccupantID { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public bool EstExterne { get; set; }

        public virtual ICollection<ContratBail> Contrats { get; set; }
        public virtual Tutelle Tutelle { get; set; }

        public Occupant()
        {
            this.Contrats = new HashSet<ContratBail>();
        }
    }
}
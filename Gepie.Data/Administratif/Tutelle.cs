using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Tutelle : Entite
    {
        public short TutelleID { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public bool EstAdministration { get; set; }
        public virtual ICollection<Occupant> Occupant { get; set; }

        public Tutelle()
        {
            this.Occupant = new HashSet<Occupant>();
        }
    }
}
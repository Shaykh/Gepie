using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gepie.Data
{
    [DisplayName("Administration de tutelle")]
    public class Tutelle : Entite
    {
        public short Id { get; set; }
        public string Code { get; set; }
        [DisplayName("Libellé")]
        public string Libelle { get; set; }
        public bool EstAdministration { get; set; }

        public virtual ICollection<Occupant> Occupant { get; set; }

        public Tutelle()
        {
            this.Occupant = new HashSet<Occupant>();
        }
    }
}
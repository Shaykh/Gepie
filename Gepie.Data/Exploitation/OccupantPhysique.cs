using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class OccupantPhysique : Occupant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Fonction { get; set; }
        public ICollection<OccupantPhysiqueFichier> Fichiers { get; set; }

        public OccupantPhysique()
        {
            this.Fichiers = new HashSet<OccupantPhysiqueFichier>();
        }
    }
}
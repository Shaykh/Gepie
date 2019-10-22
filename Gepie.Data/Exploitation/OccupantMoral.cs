using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class OccupantMoral : Occupant
    {
        public string IntituleStruture { get; set; }    
        public byte? TypeStructure { get; set; }
        public ICollection<OccupantMoralFichier> Fichiers { get; set; }

        public OccupantMoral()
        {
            this.Fichiers = new HashSet<OccupantMoralFichier>();
        }
    }
}
using System;

namespace Gepie.Data
{
    public class CompteBancaire : Entite
    {
        public string NumeroRIB { get; set; }

        public Bailleur Bailleur { get; set; }
        public Banque Banque { get; set; }
    }
}
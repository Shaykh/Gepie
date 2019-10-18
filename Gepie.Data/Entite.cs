using System;

namespace Gepie.Data
{
    public class Entite
    {
        public string Createur { get; set; }

        public string Modificateur { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DerniereModification { get; set; }

        public DateTime? DateDesactivation { get; set; }

        public Entite()
        {
            this.DateCreation = DateTime.Now;
            this.DerniereModification = DateTime.Now;
        }
    }
}
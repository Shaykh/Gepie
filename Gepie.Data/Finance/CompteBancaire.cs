using System;
using System.ComponentModel.DataAnnotations;

namespace Gepie.Data
{
    public class CompteBancaire : Entite
    {
        [Key]
        public string NumeroRIB { get; set; }

        public Bailleur Bailleur { get; set; }
        public Banque Banque { get; set; }
    }
}
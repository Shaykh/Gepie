using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Gepie.Data.Enumerations;

namespace Gepie.Data
{
    public class RetourDeFacture : Entite
    {
        public long Id { get; set; }
        [Required]
        [DisplayName("Référence")]
        public string Reference { get; set; }
        [DisplayName("Date d'édition")]
        public DateTime DateEdition { get; set; }
        public DateTime DateDeRetour { get; set; }
        public EtatRetourFacture Etat { get; set; }

        public ICollection<RetourFacture> RetourFactures { get; set; }

        public RetourDeFacture()
        {
            this.RetourFactures = new HashSet<RetourFacture>();
        }
    }
}
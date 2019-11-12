using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gepie.Data
{
    public class Banque : Entite
    {
        public short Id { get; set; }
        [Required(ErrorMessage="Le libellé est obligatoire!")]
        [DisplayName("Libellé")]
        public string Libelle { get; set; }

        public virtual ICollection<CompteBancaire> CompteBancaires { get; set; }

        public Banque()
        {
            this.CompteBancaires = new HashSet<CompteBancaire>();
        }
    }
}
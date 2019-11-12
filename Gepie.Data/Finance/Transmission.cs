using System;
using System.Collections.Generic;
using System.ComponentModel;
using Gepie.Data.Enumerations;

namespace Gepie.Data
{
    public class Transmission : Entite
    {
        [DisplayName("Date d'édition")]
        public DateTime DateEdition { get; set; }
        public DateTime? DateDeValidation { get; set; }
        public DateTime? DateDeTransmission { get; set; }
        [DisplayName("Date de réception")]
        public DateTime? DateReception { get; set; }
        public EtatTransmissionFacture EtatDeTransmission { get; set; }

        public ICollection<TransmissionFacture> TransmissionFacture { get; set; }

        public Transmission()
        {
            this.TransmissionFacture = new HashSet<TransmissionFacture>();
        }
    }
}
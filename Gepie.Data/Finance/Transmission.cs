using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Transmission : Entite
    {
        public System.DateTime DateEdition { get; set; }
        public DateTime? DateValidation { get; set; }
        public DateTime? DateTransmission { get; set; }
        public DateTime? DateReception { get; set; }
        public byte Etat { get; set; }

        public ICollection<TransmissionFacture> TransmissionFacture { get; set; }

        public Transmission()
        {
            this.TransmissionFacture = new HashSet<TransmissionFacture>();
        }
    }
}
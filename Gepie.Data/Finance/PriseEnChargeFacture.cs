using System;
using System.ComponentModel;

namespace Gepie.Data
{
    public class PriseEnChargeFacture : Entite
    {
        public long Id { get; set; }
        [DisplayName("Date de validation par la DAF")]
        public DateTime? DateValidationDAF { get; set; }
        [DisplayName("Date de validation par l'ordonnateur")]
        public DateTime? DateValidationDG { get; set; }
        [DisplayName("Date de validation par le contrôleur budgétaire")]
        public DateTime? DateValidationCB { get; set; }
        [DisplayName("Date de d'engagement")]
        public DateTime? DateEngagement { get; set; }
        [DisplayName("Date d'ordonnancement par l'ordonnateur")]
        public DateTime? DateOrdreDG { get; set; }
        [DisplayName("Date d'ordonnancement par le contrôleur budgétaire")]
        public DateTime? DateOrdreCB { get; set; }
        [DisplayName("Date d'ordonnancement")]
        public DateTime? DateOrdonnancement { get; set; }

        public Facture Facture { get; set; }
    }
}
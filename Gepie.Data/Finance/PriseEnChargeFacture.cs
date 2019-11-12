namespace Gepie.Data
{
    public class PriseEnChargeFacture : Entite
    {
        public long PriseEnChargeFactureID { get; set; }
        public Nullable<System.DateTime> DateValidationDAF { get; set; }
        public Nullable<System.DateTime> DateValidationDG { get; set; }
        public Nullable<System.DateTime> DateValidationCB { get; set; }
        public Nullable<System.DateTime> DateEngagement { get; set; }
        public Nullable<System.DateTime> DateOrdreDG { get; set; }
        public Nullable<System.DateTime> DateOrdreCB { get; set; }
        public Nullable<System.DateTime> DateOrdonnancement { get; set; }

        public Facture Facture { get; set; }
    }
}
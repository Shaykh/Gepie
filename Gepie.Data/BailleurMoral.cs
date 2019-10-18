using System;

namespace Gepie.Data
{
    public class BailleurMoral : Bailleur
    {
        public string RaisonSociale { get; set; }
        public string GerantNom { get; set; }
        public string MandantNom { get; set; }
        public byte RegimeImposition { get; set; }
    }
}
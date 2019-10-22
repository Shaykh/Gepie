using System;

namespace Gepie.Data
{
    public class Batiment : BienImmobilier
    {
        public string Ilot { get; set; }
        public string Lot { get; set; }
        public decimal SuperficieTerrain { get; set; }
    }
}
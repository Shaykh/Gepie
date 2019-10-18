using System;

namespace Gepie.Data
{
    public class Batiment
    {
        public long BatimentID { get; set; }
        public string Code { get; set; }
        public string Ilot { get; set; }
        public string Lot { get; set; }
        public string Localisation { get; set; }
        public decimal SuperficieTerrain { get; set; }
        public decimal SuperficieBatie { get; set; }
        public short NombrePieces { get; set; }
        public string CoordonneesGeo { get; set; }
        public byte? Usage { get; set; }

        public Batiment()
        {
            
        }
    }
}
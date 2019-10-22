using System;

namespace Gepie.Data
{
    public class Fichier : Entite
    {
        public long FichierID { get; set; }
        public string Libelle { get; set; }
        public string Extension { get; set; }
        public byte[] FichierData { get; set; }
    }
}
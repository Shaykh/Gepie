using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class Facture : Entite
    {
        public long FactureID { get; set; }
        public string NumeroFacture { get; set; }
        public string NumeroOrdrePaiement { get; set; }
        public string Reference { get; set; }
        public string NatureRubrique { get; set; }
        public decimal MontantFacture { get; set; }
        public decimal ResteAPayer { get; set; }
        public byte EtatTraitement { get; set; }
        public int Annee { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public FactureObjet Objet { get; set; }
        public ContratBail ContratBail { get; set; }
        public TransmissionFacture TransmissionFacture { get; set; }
        public RetourFacture RetourFacture { get; set; }
        public PriseEnChargeFacture PriseEnCharge { get; set; }
        public RejetFacture Rejet { get; set; }

        public virtual ICollection<FactureFichier> Fichiers { get; set; }
        public virtual ICollection<Paiement> Paiements { get; set; }

        public Facture()
        {
            this.Fichiers = new HashSet<FactureFichier>();
            this.Paiements = new HashSet<Paiement>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gepie.Data
{
    public class Facture : Entite
    {
        public long Id { get; set; }
        public string NumeroDeFacture { get; set; }
        [DisplayName("Numéro d'ordre de paiement")]
        public string NumeroOrdrePaiement { get; set; }
        [Required(ErrorMessage="La référence est obligatoire!")]
        [DisplayName("Référence")]
        public string Reference { get; set; }
        public string NatureDeRubrique { get; set; }
        public decimal Montant { get; set; }
        public decimal Solde { get; set; }
        public EtatTraitementFacture EtatDeTraitement { get; set; }
        [DisplayName("Année")]
        public int Annee { get; set; }
        [DisplayName("Date d'enregistrement")]
        public DateTime DateEnregistrement { get; set; }

        public FactureObjet Objet { get; set; }
        public ContratBail ContratBail { get; set; }
        public TransmissionFacture TransmissionFacture { get; set; }
        public RetourFacture RetourFacture { get; set; }
        public PriseEnChargeFacture PriseEnCharge { get; set; }
        public RejetFacture Rejet { get; set; }

        public ICollection<FactureFichier> Fichiers { get; set; }
        public ICollection<Paiement> Paiements { get; set; }

        public Facture()
        {
            this.Fichiers = new HashSet<FactureFichier>();
            this.Paiements = new HashSet<Paiement>();
        }
    }
}
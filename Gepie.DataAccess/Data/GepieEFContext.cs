using Microsoft.EntityFrameworkCore;
using Gepie.Data;

namespace Gepie.DataAccess
{
    public class GepieEFContext : DbContext
    {
        public GepieEFContext(DbContextOptions<GepieEFContext> options) : base(options)
        {
        }

        public DbSet<Tutelle> Tutelles { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Localite> Localites { get; set; }

        public DbSet<Appartement> Appartements { get; set; }
        public DbSet<BailleurMoral> BailleurMorals { get; set; }
        public DbSet<BailleurPhysique> BailleurPhysiques { get; set; }
        public DbSet<AvenantMontant> AvenantMontants { get; set; }
        public DbSet<Batiment> Batiments { get; set; }
        public DbSet<ContratBail> ContratBails { get; set; }
        public DbSet<MotifChangementPropriete> MotifChangementProprietes { get; set; }
        public DbSet<OccupantMoral> OccupantMorals { get; set; }
        public DbSet<OccupantPhysique> OccupantPhysiques { get; set; }
        public DbSet<Propriete> Proprietes { get; set; }

        public DbSet<AvenantFichier> AvenantFichiers { get; set; }
        public DbSet<BailleurFichier> BailleurFichiers { get; set; }
        public DbSet<BienFichier> BienFichiers { get; set; }
        public DbSet<ContratBailFichier> ContratBailFichiers { get; set; }
        public DbSet<FactureFichier> FactureFichiers { get; set; }
        public DbSet<OccupantMoralFichier> OccupantMoralFichiers { get; set; }
        public DbSet<OccupantPhysiqueFichier> OccupantPhysiqueFichiers { get; set; }
        public DbSet<ProprieteFichier> ProprieteFichiers { get; set; }
        public DbSet<TransmissionFichier> TransmissionFichiers { get; set; }

        public DbSet<Banque> Banques { get; set; }
        public DbSet<ChargeLocative> ChargeLocatives { get; set; }
        public DbSet<CompteBancaire> CompteBancaires { get; set; }
        public DbSet<Facture> Facture { get; set; }
        public DbSet<FactureObjet> FactureObjets { get; set; }
        public DbSet<LoyerTrimestre> LoyerTrimestres { get; set; }
        public DbSet<PriseEnChargeFacture> PriseEnChargeFactures { get; set; }
        public DbSet<RejetFacture> RejetFactures { get; set; }
        public DbSet<RetourDeFacture> RetourDeFactures { get; set; }
        public DbSet<RetourFacture> RetourFactures { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<TransmissionFacture> TransmissionFactures { get; set; }
    }
}
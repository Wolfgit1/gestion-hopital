using Microsoft.EntityFrameworkCore;
using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Core.Entities;

namespace SolutionGestionMedecin.Infrastructure
{
    public class SolutionGestionMedecinContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DossierMedical> Dossiers { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Consultation> Consultations { get; set; }

       
        public SolutionGestionMedecinContext(DbContextOptions options) : base(options)
        { }

        // Constructeur par défaut avec configuration de la base de données SQL Server
        public SolutionGestionMedecinContext() : base(new DbContextOptionsBuilder<SolutionGestionMedecinContext>()
            .UseSqlServer(@"Server=.;Database=SolutiongestionmedecinsDB;Trusted_Connection=True;")
            .Options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurer la relation Patient -> Consultations
            modelBuilder.Entity<Consultation>()
                .HasOne(c => c.Patient)
                .WithMany(p => p.Consultations)
                .HasForeignKey(c => c.PatientId)
                .OnDelete(DeleteBehavior.Cascade); // Supprimer les consultations si le patient est supprimé

            // Configurer la relation Patient -> Prescriptions
            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Patient)
                .WithMany(pat => pat.Prescriptions)
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Cascade); // Supprimer les prescriptions si le patient est supprimé

            // Appeler la méthode de base
            base.OnModelCreating(modelBuilder);
        }
    }
}

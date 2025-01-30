using Microsoft.EntityFrameworkCore;
using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Core.Interfaces;
using SolutionGestionMedecin.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Infrastructure.Repositories
{
    public class PatientRepository : EfRepository<Patient>, IPatientRepository
    {
        private readonly SolutionGestionMedecinContext _context;

        // Constructeur par défaut
        public PatientRepository()
            : this(new SolutionGestionMedecinContext(
                new DbContextOptionsBuilder<SolutionGestionMedecinContext>()
                    .UseSqlServer("Server=.;Database=SolutiongestionmedecinsDB;Trusted_Connection=True;")
                    .Options))
        {
        }

        // Constructeur avec paramètre
        public PatientRepository(SolutionGestionMedecinContext context)
            : base(context)
        {
            _context = context;
        }

        // Récupérer un patient par son ID avec ses relations associées (ex : consultations, prescriptions)
        public Patient GetByIdWithPatients(int id)
        {
            return _context.Patients
                .Include(p => p.Consultations) // Inclut les consultations associées
                .Include(p => p.Prescriptions) // Inclut les prescriptions associées
                .FirstOrDefault(p => p.Id == id);
        }

        
        public async Task<Patient> GetByIdWithPatientsAsync(int id)
        {
            return await _context.Patients
                .Include(p => p.Consultations)
                .Include(p => p.Prescriptions)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // Implémentation spécifique pour ListAsync avec une spécification
        public async Task<List<Patient>> ListAsync(ISpecification<Patient> specification)
        {
            // Applique les critères spécifiés dans la spécification
            return await _context.Patients
                .Where(specification.Criteria)
                .ToListAsync();
        }
    }
}

using SolutionGestionMedecin.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Interfaces
{
   public interface IPatientRepository : IAsyncRepository<Patient>, IRepository<Patient>

    {
        Task<Patient> GetByIdWithPatientsAsync(int id);
        Patient GetByIdWithPatients(int id);


    }
}

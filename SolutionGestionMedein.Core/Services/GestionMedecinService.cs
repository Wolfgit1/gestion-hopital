using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Services
{
    public class GestionMedecinService : IGestionMedecinService
    {
        private readonly IPatientRepository _patientRepository;

      

        public GestionMedecinService(IPatientRepository PatientRepository)
        {
            _patientRepository = PatientRepository;
          
	}


        public async Task AddPatient(Patient patient)
        {
            await _patientRepository.AddAsync(patient);
        }

      

        public async Task UpdatePatient(Patient patient)
        {
            await _patientRepository.UpdateAsync(patient);
        }

       
    }
}

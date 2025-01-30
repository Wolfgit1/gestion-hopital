
using SolutionGestionMedecin.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Interfaces
{
    public interface IGestionMedecinService
    {
        Task AddPatient(Patient patient);
        Task UpdatePatient(Patient patient);
       

      


    }
}

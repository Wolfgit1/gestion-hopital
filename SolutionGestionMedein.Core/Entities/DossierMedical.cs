using SolutionGestionMedecin.SharedKernel;
using SolutionGestionMedecin.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Entities
{
    public class DossierMedical : BaseEntity, IAggregateRoot
    {
        public string PatientNom { get; set; }
        public List<Traitement> TraitementsPasses { get; set; }

        // Constructeur
        public DossierMedical(string patientNom)
        {
            PatientNom = patientNom;
            TraitementsPasses = new List<Traitement>();
        }

        public class Traitement : BaseEntity, IAggregateRoot
        {
        }
    }
}

   
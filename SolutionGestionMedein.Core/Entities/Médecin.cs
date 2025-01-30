using SolutionGestionMedecin.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Entities
{
    public class Médecin : BaseEntity
    {
        
        public string NumeroLicence { get; set; }

       
        public string Nom { get; set; }

       
        public string Prenom { get; set; }

        
        public string Adresse { get; set; }

      
        public string NumeroTelephone { get; set; }

        
        public string AdresseCourriel { get; set; }

       
        public Médecin() { }

       
        public Médecin(string numeroLicence, string nom, string prenom, string adresse, string numeroTelephone, string adresseCourriel)
        {
            NumeroLicence = numeroLicence;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            NumeroTelephone = numeroTelephone;
            AdresseCourriel = adresseCourriel;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.Core.Entities
{
    public class Utilisateur 
    {
        public string identifiant;
        public string nomUtilisateur;
        public string motDePasse;


        public Utilisateur(string identifiant, string nomUtilisateur, string motDePasse)
        {
            this.identifiant = identifiant;
            this.nomUtilisateur = nomUtilisateur;
            this.motDePasse = motDePasse;
        }
    }
}

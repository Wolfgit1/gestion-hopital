using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.SharedKernel.Interfaces;
using SolutionGestionMedecin.SharedKernel;
using System.Collections.Generic;
using System;

public class Patient : BaseEntity, IAggregateRoot
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public string Telephone { get; set; }
    public string Courriel { get; set; }
    public DateTime DateNaissance { get; set; }

    // Relations
    public ICollection<Consultation> Consultations { get; set; } = new List<Consultation>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public Patient()
    {
    }

    public Patient(string nom, string prenom, string adresse, string telephone, string courriel, DateTime dateNaissance)
    {
        Nom = nom;
        Prenom = prenom;
        Adresse = adresse;
        Telephone = telephone;
        Courriel = courriel;
        DateNaissance = dateNaissance;
    }
}

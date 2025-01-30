using SolutionGestionMedecin.SharedKernel.Interfaces;
using SolutionGestionMedecin.SharedKernel;
using System;
using SolutionGestionMedecin.Core.Entities;

public class Prescription : BaseEntity, IAggregateRoot
{
    public string Medicament { get; set; }
    public string Dosage { get; set; }
    public string Instruction { get; set; }
    public DateTime Duree { get; set; }

    // État de la prescription avec une valeur par défaut
    public EtatPrescription Etat { get; set; } = EtatPrescription.EnCours;

    // Relation avec Patient
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    // Constructeur par défaut
    public Prescription() { }

    // Constructeur avec paramètres
    public Prescription(string medicament, string dosage, string instruction, DateTime duree, EtatPrescription etat = EtatPrescription.EnCours)
    {
        Medicament = medicament;
        Dosage = dosage;
        Instruction = instruction;
        Duree = duree;
        Etat = etat; // Définit l'état lors de la création
    }
}

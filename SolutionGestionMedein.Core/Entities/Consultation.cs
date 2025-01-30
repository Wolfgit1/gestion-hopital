using SolutionGestionMedecin.SharedKernel.Interfaces;
using SolutionGestionMedecin.SharedKernel;
using System;

public class Consultation : BaseEntity, IAggregateRoot
{
    public DateTime Date { get; set; }
    public string Motif { get; set; }
    public string Observations { get; set; }
    public string Diagnostic { get; set; }

    // Relation
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public Consultation()
    {
    }

    public Consultation(DateTime date, string motif, string observations, string diagnostic)
    {
        Date = date;
        Motif = motif;
        Observations = observations;
        Diagnostic = diagnostic;
    }
}

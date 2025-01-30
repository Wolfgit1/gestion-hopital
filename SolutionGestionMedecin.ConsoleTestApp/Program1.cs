using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Core.Interfaces;
using SolutionGestionMedecin.Infrastructure;
using SolutionGestionMedecin.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionGestionMedecin.ConsoleTestApp
{
    public class Program1
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans la gestion des patients !");
            Console.WriteLine("Choisissez une option :");
            Console.WriteLine("1 - Créer un patient, consultation et prescription");
            Console.WriteLine("2 - Rechercher un patient par nom");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Creation();
                    break;

                case "2":
                    Console.WriteLine("Entrez le nom du patient à rechercher :");
                    string nomPatient = Console.ReadLine();
                    await TestChercherPatientParNom(nomPatient);
                    break;

                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }

            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        static void Creation()
        {
            try
            {
                // Initialiser le contexte
                using var context = new SolutionGestionMedecinContext();

                // Créer un nouveau patient
                var patient = new Patient
                {
                    Nom = "Dupont",
                    Prenom = "Jean",
                    Adresse = "123 Rue Exemple",
                    Telephone = "0123456789",
                    Courriel = "jean.dupont@mail.com",
                    DateNaissance = new DateTime(1985, 5, 20)
                };

                // Créer une nouvelle consultation pour ce patient
                var consultation = new Consultation
                {
                    Date = DateTime.Now,
                    Motif = "Consultation de routine",
                    Observations = "RAS",
                    Diagnostic = "Bonne santé",
                    Patient = patient // Relation directe
                };

                // Ajouter une prescription pour ce patient
                var prescription = new Prescription
                {
                    Medicament = "Ibuprofène",
                    Dosage = "400mg",
                    Instruction = "Prendre 1 comprimé toutes les 8 heures après les repas.",
                    Duree = new DateTime(2023, 12, 20), // Date de fin
                    Etat = EtatPrescription.EnCours,
                    Patient = patient // Relation directe
                };

                // Ajouter les entités au contexte
                context.Patients.Add(patient);           // Ajouter le patient
                context.Consultations.Add(consultation); // Ajouter la consultation
                context.Prescriptions.Add(prescription); // Ajouter la prescription

                // Sauvegarder les modifications
                context.SaveChanges();

                Console.WriteLine("Patient, consultation et prescription ajoutés avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur est survenue : {ex.Message}");
            }
        }

        static async Task TestChercherPatientParNom(string nomPatient)
        {
            using (var context = new SolutionGestionMedecinContext())
            {
                var patientRepository = new PatientRepository(context);

                // Crée une spécification pour rechercher un patient par nom
                var spec = new PatientByNom(nomPatient);

                // Exécute la requête via le repository
                var patients = await patientRepository.ListAsync(spec);

                // Vérifie si des résultats existent
                var patient = patients.FirstOrDefault();

                if (patient != null)
                {
                    Console.WriteLine("Patient trouvé : ");
                    Console.WriteLine($"ID : {patient.Id}");
                    Console.WriteLine($"Nom : {patient.Nom}");
                    Console.WriteLine($"Prénom : {patient.Prenom}");
                    Console.WriteLine($"Date de Naissance : {patient.DateNaissance.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine("Patient introuvable");
                }
            }
        }
    }
}

using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail_2;

namespace WindowsFormsApp1
{
    public partial class PrescriptionForm : Form
    {
        private int _patientId;
        
        public PrescriptionForm()
        {
            InitializeComponent();
        }
        public PrescriptionForm(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
        }

        private async void btnAjouterPrescription_Click(object sender, EventArgs e)
        {
            // Vérifiez que tous les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(txtMedicament.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(txtInstructions.Text) ||
                string.IsNullOrWhiteSpace(txtDuree.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Récupérer les données saisies
                string medicament = txtMedicament.Text;
                string dosage = txtDosage.Text;
                string instruction = txtInstructions.Text;
                DateTime duree = DateTime.Parse(txtDuree.Text);

                // Créer une nouvelle prescription
                var prescription = new Prescription
                {
                    Medicament = medicament,
                    Dosage = dosage,
                    Instruction = instruction,
                    Duree = duree,
                    Etat = EtatPrescription.EnCours, // État par défaut
                    PatientId = _patientId // Lier au patient sélectionné
                };

                // Sauvegarder dans la base de données
                using var context = new SolutionGestionMedecinContext();
                context.Prescriptions.Add(prescription);
                await context.SaveChangesAsync();

                // Confirmation
                MessageBox.Show("Prescription ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser les champs
                txtMedicament.Clear();
                txtDosage.Clear();
                txtInstructions.Clear();
                txtDuree.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la prescription : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

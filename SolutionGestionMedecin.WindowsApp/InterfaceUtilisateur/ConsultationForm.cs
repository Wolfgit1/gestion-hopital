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
    public partial class ConsultationForm : Form
    {
        private int _patientId;

        public ConsultationForm()
        {
        }

        public ConsultationForm(int PatientId)
        {
            InitializeComponent();
           
            _patientId = PatientId;

            

        }


        private async void btnAjouterConsultation_Click(object sender, EventArgs e)
        {
            // Vérifier les champs obligatoires
            if (string.IsNullOrWhiteSpace(txtMotif.Text) ||
                string.IsNullOrWhiteSpace(txtObservations.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnostic.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Récupérer les données saisies
                string motif = txtMotif.Text;
                string observations = txtObservations.Text;
                string diagnostic = txtDiagnostic.Text;
                DateTime dateConsultation = dateTimePicker1.Value; // Utiliser dateTimePicker1

                // Créer une nouvelle consultation
                var consultation = new Consultation
                {
                    Date = dateConsultation,
                    Motif = motif,
                    Observations = observations,
                    Diagnostic = diagnostic,
                    PatientId = _patientId // Lier la consultation au patient sélectionné
                };

                // Ajouter la consultation dans la base de données
                using var context = new SolutionGestionMedecinContext();
                context.Consultations.Add(consultation);
                await context.SaveChangesAsync();

                // Message de confirmation
                MessageBox.Show("Consultation ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermer le formulaire après l'ajout
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de l'ajout de la consultation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
    }
}

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

namespace Travail_2
{
    public partial class HistoriquePrescription : Form
    {
        private readonly int _patientId;
        public HistoriquePrescription(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;

            // Charger les prescriptions à l'ouverture
            LoadPrescriptions();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez qu'une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Récupérer l'Identifiant de la prescription
                    int prescriptionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Identifiant"].Value);

                    // Mettre à jour l'état de la prescription dans la base de données
                    using (var context = new SolutionGestionMedecinContext())
                    {
                        var prescription = await context.Prescriptions.FindAsync(prescriptionId);

                        if (prescription != null && prescription.Etat == EtatPrescription.EnCours)
                        {
                            // Mettre à jour l'état
                            prescription.Etat = EtatPrescription.Terminé;

                            // Sauvegarder les modifications
                            await context.SaveChangesAsync();

                            // Mettre à jour l'affichage dans le DataGridView
                            dataGridView1.SelectedRows[0].Cells["Column5"].Value = "Terminé";

                            MessageBox.Show("La prescription a été fermée avec succès.",
                                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La prescription est déjà fermée ou introuvable.",
                                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue : {ex.Message}",
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une prescription à fermer.",
                                "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPrescriptions()
        {
            using (var context = new SolutionGestionMedecinContext())
            {
                // Requête pour récupérer les prescriptions liées au patient
                var prescriptions = context.Prescriptions
                    .Where(p => p.PatientId == _patientId)
                    .Select(p => new
                    {
                        Identifiant = p.Id,
                        Medicament = p.Medicament,
                        Dosage = p.Dosage,
                        Instruction = p.Instruction,
                        Duree = p.Duree.ToShortDateString(),
                        Etat = p.Etat.ToString() // État sous forme de texte
                    }).ToList();

                // Effacer les lignes existantes
                dataGridView1.Rows.Clear();

                // Ajouter les prescriptions au DataGridView
                foreach (var prescription in prescriptions)
                {
                    dataGridView1.Rows.Add(
                        prescription.Identifiant,
                        prescription.Medicament,
                        prescription.Dosage,
                        prescription.Instruction,
                        prescription.Duree,
                        prescription.Etat);
                }
            }
        }





    }
}

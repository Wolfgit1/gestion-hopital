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
using WindowsFormsApp1;

namespace Travail_2
{
    public partial class Prescription2 : Form
    {
        public Prescription2()
        {
            InitializeComponent();
            LoadPatientData();
            ConfigureDataGridView();
        }
        public void LoadPatientData()
        {
            using (var context = new SolutionGestionMedecinContext())
            {
                // Récupérer uniquement les colonnes nécessaires (Id, Nom, Prenom)
                var patients = context.Patients
                    .Select(p => new
                    {
                        p.Id,
                        p.Nom,
                        p.Prenom
                    })
                    .ToList();

                // Affecter les données au DataGridView
                dataGridView1.DataSource = patients;
            }
        }
        public void ConfigureDataGridView()
        {
            // Désactiver la génération automatique des colonnes
            dataGridView1.AutoGenerateColumns = false;

            // Effacer les colonnes existantes (si nécessaire)
            dataGridView1.Columns.Clear();

            // Ajouter manuellement les colonnes nécessaires
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true // Si vous ne voulez pas permettre l'édition
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nom",
                HeaderText = "Nom",
                DataPropertyName = "Nom"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prenom",
                HeaderText = "Prénom",
                DataPropertyName = "Prenom"
            });


        }




        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du patient dans la colonne "ID"
                int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Ouvrir le formulaire PrescriptionForm avec l'ID du patient
                PrescriptionForm prescriptionForm = new PrescriptionForm(patientId);
                prescriptionForm.Show();
            }
            else
            {
                // Afficher un message si aucune ligne n'est sélectionnée
                MessageBox.Show("Veuillez sélectionner un patient avant d'ajouter une prescription.",
                                "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du patient dans la colonne "Id"
                int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Ouvrir la fenêtre HistoriquePrescription avec l'ID du patient
                HistoriquePrescription historiquePrescription = new HistoriquePrescription(patientId);
                historiquePrescription.Show();
            }
            else
            {
                // Aucune ligne sélectionnée
                MessageBox.Show("Veuillez sélectionner un patient pour voir ses prescriptions.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

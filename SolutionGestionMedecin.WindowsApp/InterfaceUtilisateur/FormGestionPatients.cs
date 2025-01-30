using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionGestionMedecin.Core.Services;
using SolutionGestionMedecin.Infrastructure.Repositories;
using SolutionGestionMedecin.Core.Interfaces;
using SolutionGestionMedecin.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace Travail_2
{
    public partial class FormGestionPatients : Form
    {

        private readonly IGestionMedecinService _gestionMedecinService;
        public FormGestionPatients()
        {
            InitializeComponent();
            var context = new SolutionGestionMedecinContext();
            var patientRepository = new PatientRepository(); // Implémentation de IPatientRepository
            _gestionMedecinService = new GestionMedecinService(patientRepository); // Création du service
            ReloadPatientData();
            ConfigureDataGridView();
        }

        public void ConfigureDataGridView()
        {
            // Désactiver la génération automatique des colonnes
            dataGridView1.AutoGenerateColumns = false;

            // Effacer les colonnes existantes (si nécessaire)
            dataGridView1.Columns.Clear();

            // Ajouter les colonnes dans l'ordre des données
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true // Lecture seule pour éviter la modification
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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Adresse",
                HeaderText = "Adresse",
                DataPropertyName = "Adresse"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telephone",
                HeaderText = "Téléphone",
                DataPropertyName = "Telephone"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Courriel",
                HeaderText = "Courriel",
                DataPropertyName = "Courriel"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateNaissance",
                HeaderText = "Date de Naissance",
                DataPropertyName = "DateNaissance"
            });
        }

        private async Task ReloadPatientData()
        {
            using var context = new SolutionGestionMedecinContext();
            var patients = await context.Patients
                .Select(p => new
                {
                    p.Id,
                    p.Nom,
                    p.Prenom,
                    p.Adresse,
                    p.Telephone,
                    p.Courriel,
                    p.DateNaissance
                })
                .ToListAsync();

            dataGridView1.DataSource = patients;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }






        // Pour modifier les infos du patient
        private async void button1_Click(object sender, EventArgs e)
        {
            // Vérifie si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour modifier.");
                return;
            }

            // Récupérer la ligne sélectionnée
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Vérifier que la ligne n'est pas vide
            if (selectedRow.Cells["Id"].Value == null)
            {
                MessageBox.Show("La ligne sélectionnée est invalide ou incomplète.");
                return;
            }

            try
            {
                int patientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using var context = new SolutionGestionMedecinContext();

                // Charger le patient depuis la base de données
                var patient = await context.Patients.FindAsync(patientId);
                if (patient == null)
                {
                    MessageBox.Show("Patient introuvable dans la base de données.");
                    return;
                }

                // Créer et ouvrir un formulaire pour modifier les informations
                using (Form editForm = new Form())
                {
                    editForm.Text = "Modifier les informations du patient";
                    editForm.Size = new Size(400, 400);

                    // Pré-remplir les champs
                    TextBox txtNom = new TextBox { Text = patient.Nom, Location = new Point(120, 20), Width = 200 };
                    TextBox txtPrenom = new TextBox { Text = patient.Prenom, Location = new Point(120, 60), Width = 200 };
                    TextBox txtAdresse = new TextBox { Text = patient.Adresse, Location = new Point(120, 100), Width = 200 };
                    TextBox txtTelephone = new TextBox { Text = patient.Telephone, Location = new Point(120, 140), Width = 200 };
                    TextBox txtCourriel = new TextBox { Text = patient.Courriel, Location = new Point(120, 180), Width = 200 };
                    DateTimePicker dtpDateNaissance = new DateTimePicker { Value = patient.DateNaissance, Location = new Point(120, 220), Width = 200 };

                    // Bouton sauvegarder
                    Button btnSave = new Button
                    {
                        Text = "Sauvegarder",
                        Location = new Point(80, 300),
                        Size = new Size(100, 40),
                        BackColor = Color.LightGreen
                    };

                    btnSave.Click += async (s, args) =>
                    {
                        try
                        {
                            // Mettre à jour l'objet patient
                            patient.Nom = txtNom.Text;
                            patient.Prenom = txtPrenom.Text;
                            patient.Adresse = txtAdresse.Text;
                            patient.Telephone = txtTelephone.Text;
                            patient.Courriel = txtCourriel.Text;
                            patient.DateNaissance = dtpDateNaissance.Value;

                            // Sauvegarder les modifications dans la base de données
                            await context.SaveChangesAsync();

                            // Mettre à jour les données dans le DataGridView
                            selectedRow.Cells["Nom"].Value = patient.Nom;
                            selectedRow.Cells["Prenom"].Value = patient.Prenom;
                            selectedRow.Cells["Adresse"].Value = patient.Adresse;
                            selectedRow.Cells["Telephone"].Value = patient.Telephone;
                            selectedRow.Cells["Courriel"].Value = patient.Courriel;
                            selectedRow.Cells["DateNaissance"].Value = patient.DateNaissance.ToShortDateString();

                            MessageBox.Show("Les informations du patient ont été mises à jour avec succès.");
                            editForm.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Une erreur est survenue lors de la sauvegarde : {ex.Message}");
                        }
                    };

                    // Bouton annuler
                    Button btnCancel = new Button
                    {
                        Text = "Annuler",
                        Location = new Point(200, 300),
                        Size = new Size(100, 40),
                        BackColor = Color.LightCoral
                    };
                    btnCancel.Click += (s, args) => editForm.Close();

                    // Ajouter les contrôles au formulaire
                    editForm.Controls.Add(new Label { Text = "Nom:", Location = new Point(20, 20) });
                    editForm.Controls.Add(txtNom);
                    editForm.Controls.Add(new Label { Text = "Prénom:", Location = new Point(20, 60) });
                    editForm.Controls.Add(txtPrenom);
                    editForm.Controls.Add(new Label { Text = "Adresse:", Location = new Point(20, 100) });
                    editForm.Controls.Add(txtAdresse);
                    editForm.Controls.Add(new Label { Text = "Téléphone:", Location = new Point(20, 140) });
                    editForm.Controls.Add(txtTelephone);
                    editForm.Controls.Add(new Label { Text = "Courriel:", Location = new Point(20, 180) });
                    editForm.Controls.Add(txtCourriel);
                    editForm.Controls.Add(new Label { Text = "Date de Naissance:", Location = new Point(20, 220) });
                    editForm.Controls.Add(dtpDateNaissance);
                    editForm.Controls.Add(btnSave);
                    editForm.Controls.Add(btnCancel);

                    // Afficher le formulaire
                    editForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
            }
        }




    }
}


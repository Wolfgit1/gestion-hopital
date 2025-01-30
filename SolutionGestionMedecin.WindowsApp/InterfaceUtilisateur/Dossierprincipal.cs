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
    public partial class Dossierprincipal : Form
    {
        public Dossierprincipal()
        {
            InitializeComponent();
            LoadPatientData();
            ConfigureDataGridView();
        }
        public  void ConfigureDataGridView()
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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateNaissance",
                HeaderText = "Date de Naissance",
                DataPropertyName = "DateNaissance"
            });
        }
        public void LoadPatientData()
        {
            // Utilisation de l'ORM Entity Framework pour récupérer les données
            using (var context = new SolutionGestionMedecinContext())
            {
                var patients = context.Patients
                    .Select(p => new
                    {
                        p.Id,            // Identifiant du patient
                        p.Nom,           // Nom
                        p.Prenom,        // Prénom
                        p.DateNaissance  // Date de Naissance
                    })
                    .ToList();

                // Lier les données au DataGridView
                dataGridView1.DataSource = patients;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez qu'une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Récupérer l'identifiant du patient dans la colonne "id"
                    int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                    // Ouvrir le formulaire Dossier avec l'identifiant du patient
                    Dossier formDossier = new Dossier(patientId);
                    formDossier.ShowDialog(); // Affiche le formulaire en modal
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de l'ouverture du dossier : {ex.Message}",
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message si aucune ligne n'est sélectionnée
                MessageBox.Show("Veuillez sélectionner un patient pour consulter son dossier médical.",
                                "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

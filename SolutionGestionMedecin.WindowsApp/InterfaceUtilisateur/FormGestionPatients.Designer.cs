using Microsoft.Data.SqlClient;
using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.Infrastructure.Repositories;
using SolutionGestionMedecin.Infrastructure;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Travail_2
{
    partial class FormGestionPatients
    {
        private System.ComponentModel.IContainer components = null;
        private int patientIdCounter = 1; // Initialisation de l'identifiant de départ


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si la cellule cliquée est dans la colonne "Actions" (le bouton "Modifier")
            if (e.ColumnIndex == dataGridView1.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                // Récupère les informations de la ligne sélectionnée
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int patientId = (int)row.Cells["Column6"].Value;
                string nom = row.Cells["Column1"].Value?.ToString();
                string prenom = row.Cells["Column2"].Value?.ToString();
                string adresse = row.Cells["Column3"].Value?.ToString();
                string telephone = row.Cells["Téléphone"].Value?.ToString();
                string courriel = row.Cells["Courriel"].Value?.ToString();
                DateTime dateNaissance = DateTime.Parse(row.Cells["Column4"].Value?.ToString());

                // Ouvre le formulaire de modification en passant les données du patient
                using (Form editForm = new Form())
                {
                    editForm.Text = "Modifier les informations du patient";
                    editForm.Size = new Size(400, 400);

                    TextBox txtNom = new TextBox { Text = nom, Location = new Point(120, 20), Width = 200 };
                    TextBox txtPrenom = new TextBox { Text = prenom, Location = new Point(120, 60), Width = 200 };
                    TextBox txtAdresse = new TextBox { Text = adresse, Location = new Point(120, 100), Width = 200 };
                    TextBox txtTelephone = new TextBox { Text = telephone, Location = new Point(120, 140), Width = 200 };
                    TextBox txtCourriel = new TextBox { Text = courriel, Location = new Point(120, 180), Width = 200 };
                    DateTimePicker dtpDateNaissance = new DateTimePicker { Value = dateNaissance, Location = new Point(120, 220), Width = 200 };

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
                            // Mise à jour de la base de données
                            var patient = new Patient
                            {
                                Id = patientId,
                                Nom = txtNom.Text,
                                Prenom = txtPrenom.Text,
                                Adresse = txtAdresse.Text,
                                Telephone = txtTelephone.Text,
                                Courriel = txtCourriel.Text,
                                DateNaissance = dtpDateNaissance.Value
                            };

                            var context = new SolutionGestionMedecinContext();
                            var patientRepository = new PatientRepository(context);
                            await patientRepository.UpdateAsync(patient);
                            await context.SaveChangesAsync();

                            // Mise à jour de la ligne avec les nouvelles données
                            row.Cells["Column1"].Value = txtNom.Text;
                            row.Cells["Column2"].Value = txtPrenom.Text;
                            row.Cells["Column3"].Value = txtAdresse.Text;
                            row.Cells["Téléphone"].Value = txtTelephone.Text;
                            row.Cells["Courriel"].Value = txtCourriel.Text;
                            row.Cells["Column4"].Value = dtpDateNaissance.Value.ToShortDateString();

                            MessageBox.Show("Les informations du patient ont été mises à jour avec succès.");
                            editForm.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Une erreur est survenue : {ex.Message}");
                        }
                    };

                    Button btnCancel = new Button
                    {
                        Text = "Annuler",
                        Location = new Point(200, 300),
                        Size = new Size(100, 40),
                        BackColor = Color.LightCoral
                    };
                    btnCancel.Click += (s, args) => editForm.Close();

                    // Ajout des contrôles au formulaire de modification
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

                    // Affiche le formulaire de modification
                    editForm.ShowDialog();
                }
            }
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPatients));
            label1 = new Label();
            label2 = new Label();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblAdresse = new Label();
            txtAdresse = new TextBox();
            lblTelephone = new Label();
            txtTelephone = new TextBox();
            lblCourriel = new Label();
            txtCourriel = new TextBox();
            lblDateNaissance = new Label();
            dtpDateNaissance = new DateTimePicker();
            btnAnnuler = new Button();
            btnSauvegarder = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Téléphone = new DataGridViewTextBoxColumn();
            Courriel = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 115, 232);
            label1.Location = new Point(193, 12);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 0;
            label1.Text = "Nouvelle fiche patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(36, 63);
            label2.Name = "label2";
            label2.Size = new Size(387, 27);
            label2.TabIndex = 1;
            label2.Text = "Entrez les informations du patient :";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(36, 108);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(45, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(153, 108);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(250, 27);
            txtNom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(18, 169);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(63, 20);
            lblPrenom.TabIndex = 4;
            lblPrenom.Text = "Prénom:";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(153, 162);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(250, 27);
            txtPrenom.TabIndex = 5;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(19, 210);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(64, 20);
            lblAdresse.TabIndex = 6;
            lblAdresse.Text = "Adresse:";
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(153, 207);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(250, 27);
            txtAdresse.TabIndex = 7;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(18, 266);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(81, 20);
            lblTelephone.TabIndex = 8;
            lblTelephone.Text = "Téléphone:";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(153, 263);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(250, 27);
            txtTelephone.TabIndex = 9;
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Location = new Point(19, 322);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new Size(64, 20);
            lblCourriel.TabIndex = 10;
            lblCourriel.Text = "Courriel:";
            // 
            // txtCourriel
            // 
            txtCourriel.Location = new Point(153, 319);
            txtCourriel.Name = "txtCourriel";
            txtCourriel.Size = new Size(250, 27);
            txtCourriel.TabIndex = 11;
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new Point(3, 372);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new Size(132, 20);
            lblDateNaissance.TabIndex = 12;
            lblDateNaissance.Text = "Date de naissance:";
            // 
            // dtpDateNaissance
            // 
            dtpDateNaissance.Location = new Point(162, 367);
            dtpDateNaissance.Name = "dtpDateNaissance";
            dtpDateNaissance.Size = new Size(250, 27);
            dtpDateNaissance.TabIndex = 13;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.LightCoral;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI", 10F);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(142, 427);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(120, 40);
            btnAnnuler.TabIndex = 14;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.BackColor = Color.SeaGreen;
            btnSauvegarder.FlatStyle = FlatStyle.Flat;
            btnSauvegarder.Font = new Font("Segoe UI", 10F);
            btnSauvegarder.ForeColor = Color.White;
            btnSauvegarder.Location = new Point(292, 427);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(120, 40);
            btnSauvegarder.TabIndex = 15;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = false;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNom);
            panel1.Controls.Add(btnAnnuler);
            panel1.Controls.Add(lblDateNaissance);
            panel1.Controls.Add(btnSauvegarder);
            panel1.Controls.Add(txtCourriel);
            panel1.Controls.Add(dtpDateNaissance);
            panel1.Controls.Add(lblCourriel);
            panel1.Controls.Add(lblTelephone);
            panel1.Controls.Add(lblAdresse);
            panel1.Controls.Add(txtTelephone);
            panel1.Controls.Add(txtPrenom);
            panel1.Controls.Add(txtAdresse);
            panel1.Controls.Add(lblPrenom);
            panel1.Controls.Add(lblNom);
            panel1.Location = new Point(37, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 505);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(26, 115, 232);
            label3.Location = new Point(73, 548);
            label3.Name = "label3";
            label3.Size = new Size(515, 32);
            label3.TabIndex = 18;
            label3.Text = "Consulation et modification des fiches patients";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 548);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Téléphone, Courriel, Column4 });
            dataGridView1.Location = new Point(28, 599);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1138, 203);
            dataGridView1.TabIndex = 20;
            // 
            // Column6
            // 
            Column6.HeaderText = "Identifiant";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nom";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Prénom";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adresse";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Téléphone
            // 
            Téléphone.HeaderText = "Téléphone";
            Téléphone.MinimumWidth = 6;
            Téléphone.Name = "Téléphone";
            Téléphone.Width = 125;
            // 
            // Courriel
            // 
            Courriel.HeaderText = "Courriel";
            Courriel.MinimumWidth = 6;
            Courriel.Name = "Courriel";
            Courriel.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date de naissance";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(179, 821);
            button1.Name = "button1";
            button1.Size = new Size(201, 75);
            button1.TabIndex = 26;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGestionPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 977);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FormGestionPatients";
            Text = "Gestion des patients";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private async void btnSauvegarder_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string adresse = txtAdresse.Text;
            string telephone = txtTelephone.Text;
            string courriel = txtCourriel.Text;
            DateTime dateNaissance = dtpDateNaissance.Value;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(adresse))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            try
            {
                var patient = new Patient
                {
                    Nom = nom,
                    Prenom = prenom,
                    Adresse = adresse,
                    Telephone = telephone,
                    Courriel = courriel,
                    DateNaissance = dateNaissance
                };

                using var context = new SolutionGestionMedecinContext();
                var patientRepository = new PatientRepository(context);

                await patientRepository.AddAsync(patient);

                MessageBox.Show("Les informations du patient ont été sauvegardées avec succès.");

                // Rechargez les données dans le DataGridView
                await ReloadPatientData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }




        private Label label1;
        private Label label2;
        private Label lblNom;
        private TextBox txtNom;
        private Label lblPrenom;
        private TextBox txtPrenom;
        private Label lblAdresse;
        private TextBox txtAdresse;
        private Label lblTelephone;
        private TextBox txtTelephone;
        private Label lblCourriel;
        private TextBox txtCourriel;
        private Label lblDateNaissance;
        private DateTimePicker dtpDateNaissance;
        private Button btnAnnuler;
        private Button btnSauvegarder;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Téléphone;
        private DataGridViewTextBoxColumn Courriel;
        private DataGridViewTextBoxColumn Column4;
    }
}

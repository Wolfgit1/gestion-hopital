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
    public partial class Dossier : Form
    {
        private int _patientId;
        public Dossier(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            using (var context = new SolutionGestionMedecinContext())
            {
                // Charger les consultations du patient
                var consultations = context.Consultations
                    .Where(c => c.PatientId == _patientId)
                    .Select(c => new
                    {
                        Identifiant = c.Id,
                        Date = c.Date,
                        Motif = c.Motif,
                        Observation = c.Observations,
                        Diagnostic = c.Diagnostic
                    })
                    .ToList();

                // Ajouter les consultations dans le DataGridView existant
                dataGridView2.Rows.Clear(); // Efface les lignes existantes avant d'ajouter les nouvelles
                foreach (var consultation in consultations)
                {
                    dataGridView2.Rows.Add(
                        consultation.Identifiant,
                        consultation.Date,
                        consultation.Motif,
                        consultation.Observation,
                        consultation.Diagnostic
                    );
                }

                // Charger les prescriptions du patient
                var prescriptions = context.Prescriptions
                    .Where(p => p.PatientId == _patientId)
                    .Select(p => new
                    {
                        Identifiant = p.Id,
                        Medicament = p.Medicament,
                        Dosage = p.Dosage,
                        Instruction = p.Instruction,
                        Duree = p.Duree
                    })
                    .ToList();

                // Ajouter les prescriptions dans le DataGridView existant
                dataGridView1.Rows.Clear(); // Efface les lignes existantes avant d'ajouter les nouvelles
                foreach (var prescription in prescriptions)
                {
                    dataGridView1.Rows.Add(
                        prescription.Identifiant,
                        prescription.Medicament,
                        prescription.Dosage,
                        prescription.Instruction,
                        prescription.Duree
                    );
                }
            }
        }


        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Identifiant = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBox1 = new TextBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 14F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(217, 29);
            label2.TabIndex = 0;
            label2.Text = "Id Dossier : 20A456";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 4;
            label1.Text = "Liste des prescriptions";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Identifiant, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(1100, 142);
            dataGridView1.TabIndex = 5;
            // 
            // Identifiant
            // 
            Identifiant.HeaderText = "Identifiant";
            Identifiant.MinimumWidth = 6;
            Identifiant.Name = "Identifiant";
            Identifiant.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nom du médicament";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Dosage";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Instruction";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "Durée de traitement";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(198, 23);
            label4.TabIndex = 6;
            label4.Text = "Consultations du patient";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dataGridView2.Location = new Point(12, 109);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1209, 161);
            dataGridView2.TabIndex = 7;
            // 
            // Column5
            // 
            Column5.HeaderText = "Identifiant de la consultation";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Motif";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 300;
            // 
            // Column8
            // 
            Column8.HeaderText = "Observation";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 300;
            // 
            // Column9
            // 
            Column9.HeaderText = "Diagnostic";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 300;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(12, 481);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 8;
            label5.Text = "Traitements passés";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 519);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(660, 192);
            textBox1.TabIndex = 9;
           
            // 
            // Dossier
            // 
            ClientSize = new Size(1271, 855);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Dossier";
            Load += Dossier_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private TextBox textBox1;

        private void Dossier_Load(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox2;
        private Label label6;
        private LinkLabel linkLabel2;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultationForm consultationForm = new ConsultationForm();
            consultationForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrescriptionForm prescriptionForm = new PrescriptionForm();
            prescriptionForm.Show();
        }

        private DataGridViewTextBoxColumn Identifiant;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}

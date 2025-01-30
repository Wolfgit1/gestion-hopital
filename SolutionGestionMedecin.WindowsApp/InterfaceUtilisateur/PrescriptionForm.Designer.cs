using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class PrescriptionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitre = new Label();
            lblInstructions = new Label();
            txtMedicament = new TextBox();
            txtDosage = new TextBox();
            txtInstructions = new TextBox();
            txtDuree = new TextBox();
            lblMedicament = new Label();
            lblDosage = new Label();
            lblUsageInstructions = new Label();
            lblDuree = new Label();
            btnAjouterPrescription = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitre.Location = new Point(252, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(260, 29);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Nouvelle Prescription";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Arial", 10F);
            lblInstructions.Location = new Point(31, 62);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(316, 19);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Entrez les informations de la prescription :";
            // 
            // txtMedicament
            // 
            txtMedicament.Location = new Point(226, 100);
            txtMedicament.Multiline = true;
            txtMedicament.Name = "txtMedicament";
            txtMedicament.Size = new Size(247, 77);
            txtMedicament.TabIndex = 5;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(226, 210);
            txtDosage.Multiline = true;
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(247, 77);
            txtDosage.TabIndex = 7;
            // 
            // txtInstructions
            // 
            txtInstructions.Location = new Point(226, 324);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(247, 77);
            txtInstructions.TabIndex = 9;
            // 
            // txtDuree
            // 
            txtDuree.Location = new Point(226, 444);
            txtDuree.Multiline = true;
            txtDuree.Name = "txtDuree";
            txtDuree.Size = new Size(247, 77);
            txtDuree.TabIndex = 11;
            // 
            // lblMedicament
            // 
            lblMedicament.AutoSize = true;
            lblMedicament.Location = new Point(32, 139);
            lblMedicament.Name = "lblMedicament";
            lblMedicament.Size = new Size(95, 20);
            lblMedicament.TabIndex = 4;
            lblMedicament.Text = "Médicament:";
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new Point(32, 242);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(63, 20);
            lblDosage.TabIndex = 6;
            lblDosage.Text = "Dosage:";
            // 
            // lblUsageInstructions
            // 
            lblUsageInstructions.AutoSize = true;
            lblUsageInstructions.Location = new Point(31, 362);
            lblUsageInstructions.Name = "lblUsageInstructions";
            lblUsageInstructions.Size = new Size(168, 20);
            lblUsageInstructions.TabIndex = 8;
            lblUsageInstructions.Text = "Instructions d'utilisation:";
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Location = new Point(32, 501);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(146, 20);
            lblDuree.TabIndex = 10;
            lblDuree.Text = "Durée de traitement:";
            // 
            // btnAjouterPrescription
            // 
            btnAjouterPrescription.BackColor = Color.FromArgb(0, 192, 192);
            btnAjouterPrescription.Location = new Point(635, 242);
            btnAjouterPrescription.Name = "btnAjouterPrescription";
            btnAjouterPrescription.Size = new Size(223, 80);
            btnAjouterPrescription.TabIndex = 12;
            btnAjouterPrescription.Text = "Ajouter Prescription";
            btnAjouterPrescription.UseVisualStyleBackColor = false;
            btnAjouterPrescription.Click += btnAjouterPrescription_Click;
            // 
            // PrescriptionForm
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(1052, 653);
            Controls.Add(lblTitre);
            Controls.Add(lblInstructions);
            Controls.Add(lblMedicament);
            Controls.Add(txtMedicament);
            Controls.Add(lblDosage);
            Controls.Add(txtDosage);
            Controls.Add(lblUsageInstructions);
            Controls.Add(txtInstructions);
            Controls.Add(lblDuree);
            Controls.Add(txtDuree);
            Controls.Add(btnAjouterPrescription);
            ForeColor = SystemColors.ControlText;
            Name = "PrescriptionForm";
            Text = "Gestion des Prescriptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label lblUsageInstructions;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtMedicament;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.TextBox txtDuree;

        private System.Windows.Forms.Button btnAjouterPrescription;
    }
}

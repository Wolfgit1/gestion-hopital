using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class ConsultationForm
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
            datePickerConsultation = new DateTimePicker();
            txtMotif = new TextBox();
            txtObservations = new TextBox();
            txtDiagnostic = new TextBox();
            btnAjouterConsultation = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblDateConsultation = new Label();
            lblMotif = new Label();
            lblObservations = new Label();
            lblDiagnostic = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // datePickerConsultation
            // 
            datePickerConsultation.Location = new Point(7156, 8821);
            datePickerConsultation.Margin = new Padding(3, 4, 3, 4);
            datePickerConsultation.Name = "datePickerConsultation";
            datePickerConsultation.Size = new Size(250, 27);
            datePickerConsultation.TabIndex = 1;
            // 
            // txtMotif
            // 
            txtMotif.Location = new Point(152, 242);
            txtMotif.Margin = new Padding(3, 4, 3, 4);
            txtMotif.Multiline = true;
            txtMotif.Name = "txtMotif";
            txtMotif.Size = new Size(239, 64);
            txtMotif.TabIndex = 2;
            // 
            // txtObservations
            // 
            txtObservations.Location = new Point(152, 366);
            txtObservations.Margin = new Padding(3, 4, 3, 4);
            txtObservations.Multiline = true;
            txtObservations.Name = "txtObservations";
            txtObservations.Size = new Size(239, 62);
            txtObservations.TabIndex = 3;
            // 
            // txtDiagnostic
            // 
            txtDiagnostic.Location = new Point(152, 459);
            txtDiagnostic.Margin = new Padding(3, 4, 3, 4);
            txtDiagnostic.Multiline = true;
            txtDiagnostic.Name = "txtDiagnostic";
            txtDiagnostic.Size = new Size(239, 61);
            txtDiagnostic.TabIndex = 4;
            // 
            // btnAjouterConsultation
            // 
            btnAjouterConsultation.BackColor = Color.FromArgb(0, 192, 192);
            btnAjouterConsultation.Font = new Font("Segoe UI", 10F);
            btnAjouterConsultation.Location = new Point(525, 307);
            btnAjouterConsultation.Margin = new Padding(3, 4, 3, 4);
            btnAjouterConsultation.Name = "btnAjouterConsultation";
            btnAjouterConsultation.Size = new Size(261, 86);
            btnAjouterConsultation.TabIndex = 5;
            btnAjouterConsultation.Text = "Ajouter Consultation";
            btnAjouterConsultation.UseVisualStyleBackColor = false;
            btnAjouterConsultation.Click += btnAjouterConsultation_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(327, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nouvelle Consultation";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Arial", 12F);
            lblSubtitle.Location = new Point(25, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(379, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Entrez les informations de la consultation :";
            // 
            // lblDateConsultation
            // 
            lblDateConsultation.AutoSize = true;
            lblDateConsultation.Location = new Point(25, 168);
            lblDateConsultation.Name = "lblDateConsultation";
            lblDateConsultation.Size = new Size(156, 20);
            lblDateConsultation.TabIndex = 3;
            lblDateConsultation.Text = "Date de Consultation :";
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(34, 245);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(52, 20);
            lblMotif.TabIndex = 4;
            lblMotif.Text = "Motif :";
            // 
            // lblObservations
            // 
            lblObservations.AutoSize = true;
            lblObservations.Location = new Point(25, 373);
            lblObservations.Name = "lblObservations";
            lblObservations.Size = new Size(102, 20);
            lblObservations.TabIndex = 5;
            lblObservations.Text = "Observations :";
            // 
            // lblDiagnostic
            // 
            lblDiagnostic.AutoSize = true;
            lblDiagnostic.Location = new Point(25, 471);
            lblDiagnostic.Name = "lblDiagnostic";
            lblDiagnostic.Size = new Size(87, 20);
            lblDiagnostic.TabIndex = 6;
            lblDiagnostic.Text = "Diagnostic :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(183, 161);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // ConsultationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 794);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblDateConsultation);
            Controls.Add(datePickerConsultation);
            Controls.Add(lblMotif);
            Controls.Add(txtMotif);
            Controls.Add(lblObservations);
            Controls.Add(txtObservations);
            Controls.Add(lblDiagnostic);
            Controls.Add(txtDiagnostic);
            Controls.Add(btnAjouterConsultation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultationForm";
            Text = "Gestion des Consultations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DateTimePicker datePickerConsultation;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Button btnAjouterConsultation;
        private System.Windows.Forms.Label lblDateConsultation;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column4;
    }
}


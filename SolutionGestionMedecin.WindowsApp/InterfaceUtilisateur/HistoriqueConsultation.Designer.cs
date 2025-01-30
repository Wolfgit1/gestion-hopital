using System.Drawing;
using System.Windows.Forms;

namespace Travail_2
{
    partial class HistoriqueConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView2 = new DataGridView();
            label2 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dataGridView2.Location = new Point(9, 100);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1171, 221);
            dataGridView2.TabIndex = 8;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 14F);
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(217, 29);
            label2.TabIndex = 9;
            label2.Text = "Id Dossier : 20A456";
            // 
            // Column5
            // 
            Column5.HeaderText = "Identifiant de la consultation";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
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
            // HistoriqueConsultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 615);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Name = "HistoriqueConsultation";
            Text = "Historique des consultations";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
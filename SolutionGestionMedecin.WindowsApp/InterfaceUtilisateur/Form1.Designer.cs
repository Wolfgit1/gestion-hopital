using System;
using System.Drawing;
using System.Windows.Forms;

namespace Travail_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            buttonLogin = new Button();
            pictureBox1 = new PictureBox();
            labelWelcome = new Label();
            labelInstruction = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelWelcome);
            panel1.Controls.Add(labelInstruction);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(textBoxPassword);
            panel1.Location = new Point(182, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 424);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonLogin);
            panel2.Location = new Point(233, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 53);
            panel2.TabIndex = 8;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LightSkyBlue;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(-5, -10);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(176, 73);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Connexion";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(449, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.DarkBlue;
            labelWelcome.Location = new Point(233, 62);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(157, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Connexion";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Font = new Font("Arial", 10F);
            labelInstruction.ForeColor = Color.DarkSlateGray;
            labelInstruction.Location = new Point(204, 125);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(224, 19);
            labelInstruction.TabIndex = 1;
            labelInstruction.Text = "Veuillez entrer vos identifiants";
            labelInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(39, 189);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(123, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Nom d'utilisateur";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(204, 189);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(39, 270);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(98, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Mot de passe";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(204, 263);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 500);
            label1.Name = "label1";
            label1.Size = new Size(297, 23);
            label1.TabIndex = 1;
            label1.Text = "Les identifiants de connexion sont : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(286, 544);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 2;
            label2.Text = "Nom d'utiliisateur : admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(540, 544);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 3;
            label3.Text = "Mot de passe : password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Système de gestion médicale";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Vérification de la connexion (simples vérifications en dur pour l'exemple)
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Connexion réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Créer une instance de Form2
                Form2 form2 = new Form2();

                // Montrer le nouveau formulaire
                form2.Show();

                // Cacher le formulaire actuel (Form1)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

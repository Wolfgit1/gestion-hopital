using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Travail_2
{
    public partial class Form2 : Form
    {
        private Panel topNavigationPanel;
        private Button btnAccueilTop;
        private Button btnGestionPatientsTop;
        private Button btnGestionConsultationsTop;
        private Button btnGestionPrescriptionsTop;
        private Button btnRapportsTop;

        private Button btnAccueilSide;
        private Button btnGestionPatientsSide;
        private Button btnGestionConsultationsSide;
        private Button btnGestionPrescriptionsSide;
        private Button btnRapportsSide;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            topNavigationPanel = new Panel();
            menuStrip1 = new MenuStrip();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            gestionDesConsultationsToolStripMenuItem = new ToolStripMenuItem();
            gestionDesConsulationsToolStripMenuItem = new ToolStripMenuItem();
            gestionDesToolStripMenuItem = new ToolStripMenuItem();
            rapportsEtAnalysesToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            sideNavigationPanel = new Panel();
            topNavigationPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            sideNavigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topNavigationPanel
            // 
            topNavigationPanel.BackColor = Color.White;
            topNavigationPanel.Controls.Add(menuStrip1);
            topNavigationPanel.Dock = DockStyle.Top;
            topNavigationPanel.Location = new Point(248, 0);
            topNavigationPanel.Name = "topNavigationPanel";
            topNavigationPanel.Size = new Size(1010, 34);
            topNavigationPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, gestionDesConsultationsToolStripMenuItem, gestionDesConsulationsToolStripMenuItem, gestionDesToolStripMenuItem, rapportsEtAnalysesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Gestion des consulations";
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(71, 24);
            accueilToolStripMenuItem.Text = "Accueil";
            // 
            // gestionDesConsultationsToolStripMenuItem
            // 
            gestionDesConsultationsToolStripMenuItem.Name = "gestionDesConsultationsToolStripMenuItem";
            gestionDesConsultationsToolStripMenuItem.Size = new Size(157, 24);
            gestionDesConsultationsToolStripMenuItem.Text = "Gestion des patients";
            gestionDesConsultationsToolStripMenuItem.Click += gestionDesConsultationsToolStripMenuItem_Click;
            // 
            // gestionDesConsulationsToolStripMenuItem
            // 
            gestionDesConsulationsToolStripMenuItem.Name = "gestionDesConsulationsToolStripMenuItem";
            gestionDesConsulationsToolStripMenuItem.Size = new Size(225, 24);
            gestionDesConsulationsToolStripMenuItem.Text = "Gestion des dossiers médicaux";
            gestionDesConsulationsToolStripMenuItem.Click += gestionDesConsulationsToolStripMenuItem_Click;
            // 
            // gestionDesToolStripMenuItem
            // 
            gestionDesToolStripMenuItem.Name = "gestionDesToolStripMenuItem";
            gestionDesToolStripMenuItem.Size = new Size(191, 24);
            gestionDesToolStripMenuItem.Text = "Gestion des consultations";
            gestionDesToolStripMenuItem.Click += gestionDesToolStripMenuItem_Click;
            // 
            // rapportsEtAnalysesToolStripMenuItem
            // 
            rapportsEtAnalysesToolStripMenuItem.Name = "rapportsEtAnalysesToolStripMenuItem";
            rapportsEtAnalysesToolStripMenuItem.Size = new Size(189, 24);
            rapportsEtAnalysesToolStripMenuItem.Text = "Gestion des prescriptions";
            rapportsEtAnalysesToolStripMenuItem.Click += rapportsEtAnalysesToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(278, 122);
            label2.Name = "label2";
            label2.Size = new Size(358, 37);
            label2.TabIndex = 2;
            label2.Text = "Bienvenue dans votre espace";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(625, 52);
            label3.Name = "label3";
            label3.Size = new Size(127, 46);
            label3.TabIndex = 3;
            label3.Text = "Accueil";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(953, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 215);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 14F);
            label4.Location = new Point(327, 225);
            label4.Name = "label4";
            label4.Size = new Size(351, 32);
            label4.TabIndex = 5;
            label4.Text = "Quelques liens d'accès rapides :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.FromArgb(192, 64, 0);
            linkLabel1.Location = new Point(303, 298);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Créer une fiche patient";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.FromArgb(192, 64, 0);
            linkLabel2.Location = new Point(303, 347);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(230, 23);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Consulter un dossier médical";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 10F);
            linkLabel3.LinkColor = Color.FromArgb(192, 64, 0);
            linkLabel3.Location = new Point(303, 394);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(184, 23);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Créer une consultation";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(278, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(262, 298);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(262, 346);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 21);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(262, 394);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 21);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(1162, 52);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 13;
            label5.Text = "Connecté ";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1125, 52);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 20);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(27, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(176, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Location = new Point(72, 155);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Bienvenue";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(-44, 196);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(337, 395);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 68);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(-11, -8);
            button1.Name = "button1";
            button1.Size = new Size(362, 90);
            button1.TabIndex = 0;
            button1.Text = "Gestion des patients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 68);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(-11, -8);
            button2.Name = "button2";
            button2.Size = new Size(362, 87);
            button2.TabIndex = 1;
            button2.Text = "Gestion des dossiers médicaux";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Location = new Point(3, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 63);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(-11, -15);
            button3.Name = "button3";
            button3.Size = new Size(349, 83);
            button3.TabIndex = 1;
            button3.Text = "Gestion des consultations";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Location = new Point(3, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 68);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(-20, -12);
            button4.Name = "button4";
            button4.Size = new Size(371, 88);
            button4.TabIndex = 1;
            button4.Text = "Gestion des prescriptions";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sideNavigationPanel
            // 
            sideNavigationPanel.BackColor = Color.FromArgb(112, 128, 144);
            sideNavigationPanel.Controls.Add(flowLayoutPanel1);
            sideNavigationPanel.Controls.Add(label1);
            sideNavigationPanel.Controls.Add(pictureBox4);
            sideNavigationPanel.Controls.Add(pictureBox1);
            sideNavigationPanel.Dock = DockStyle.Left;
            sideNavigationPanel.Location = new Point(0, 0);
            sideNavigationPanel.Name = "sideNavigationPanel";
            sideNavigationPanel.Size = new Size(248, 718);
            sideNavigationPanel.TabIndex = 1;
            // 
            // Form2
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1258, 718);
            Controls.Add(pictureBox8);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(topNavigationPanel);
            Controls.Add(sideNavigationPanel);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Système de gestion médicale";
            topNavigationPanel.ResumeLayout(false);
            topNavigationPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            sideNavigationPanel.ResumeLayout(false);
            sideNavigationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem gestionDesConsultationsToolStripMenuItem;
        private ToolStripMenuItem gestionDesConsulationsToolStripMenuItem;
        private ToolStripMenuItem gestionDesToolStripMenuItem;
        private ToolStripMenuItem rapportsEtAnalysesToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel2;

        private void button1_Click(object sender, EventArgs e)
        {
            // Change la couleur du bouton actif pour indiquer la sélection
            button1.BackColor = Color.White;

            // Crée une instance du formulaire cible (FormGestionPatients)
            FormGestionPatients formGestionPatient = new FormGestionPatients();

            // Ajoute un événement de fermeture au formulaire cible
            formGestionPatient.FormClosed += (s, args) =>
            {
                // Réinitialise la couleur du bouton quand le formulaire est fermé
                button1.BackColor = Color.SlateGray;
            };

            // Affiche le formulaire sans fermer le formulaire actuel
            formGestionPatient.Show();
        }

        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crée une nouvelle instance du formulaire cible (par exemple FormGestionPatient)
            FormGestionPatients formGestionPatient = new FormGestionPatients();

            // Affiche le formulaire sans fermer le formulaire actuel
            formGestionPatient.Show();
        }

        private Label label5;
        private PictureBox pictureBox8;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;

            // Crée une instance du formulaire cible (FormGestionPatients)
            Dossierprincipal dossierprincipal1 = new Dossierprincipal();

            // Ajoute un événement de fermeture au formulaire cible
            dossierprincipal1.FormClosed += (s, args) =>
            {
                // Réinitialise la couleur du bouton quand le formulaire est fermé
                button2.BackColor = Color.SlateGray;
            };

            // Affiche le formulaire sans fermer le formulaire actuel


            dossierprincipal1.Show();
        }

        private void gestionDesConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionPatients formGestionPatient = new FormGestionPatients();

            // Affiche le formulaire sans fermer le formulaire actuel
            formGestionPatient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            Consultation2 consultation2 = new Consultation2();
            consultation2.FormClosed += (s, args) =>
            {
                // Réinitialise la couleur du bouton quand le formulaire est fermé
                button3.BackColor = Color.SlateGray;
            };

            // Affiche le formulaire sans fermer le formulaire actuel
            consultation2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;

            Prescription2 prescription2 = new Prescription2();
            prescription2.FormClosed += (s, args) =>
            {
                // Réinitialise la couleur du bouton quand le formulaire est fermé
                button4.BackColor = Color.SlateGray;
            };

            // Affiche le formulaire sans fermer le formulaire actuel
            prescription2.Show();


        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Panel panel3;
        private Button button4;
        private Panel sideNavigationPanel;

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gestionDesConsulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dossierprincipal dossierprincipal1 = new Dossierprincipal();
            dossierprincipal1.Show();
        }

        private void gestionDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation2 consultation2 = new Consultation2();
            consultation2.Show();
        }

        private void rapportsEtAnalysesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prescription2 prescription2 = new Prescription2();
            prescription2.Show();
        }
    }
}

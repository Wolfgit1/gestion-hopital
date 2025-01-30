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
    public partial class HistoriqueConsultation : Form
    {
        private readonly int _patientId;

        public HistoriqueConsultation()
        {
        }

        public HistoriqueConsultation(int PatientId)
        {
            InitializeComponent();
          
            _patientId = PatientId;

            // Chargez les consultations à l'ouverture
            LoadConsultations();
        }
        private void LoadConsultations()
        {
            using (var context = new SolutionGestionMedecinContext())
            {
                // Requête pour récupérer les consultations liées au patient
                var consultations = context.Consultations
                    .Where(c => c.PatientId == _patientId)
                    .Select(c => new
                    {
                        Identifiant = c.Id,
                        Date = c.Date,
                        Motif = c.Motif,
                        Observation = c.Observations,
                        Diagnostic = c.Diagnostic
                    }).ToList();

                // Effacez les lignes existantes
                dataGridView2.Rows.Clear();

                // Ajoutez les consultations au DataGridView
                foreach (var consultation in consultations)
                {
                    dataGridView2.Rows.Add(
                        consultation.Identifiant,
                        consultation.Date.ToShortDateString(),
                        consultation.Motif,
                        consultation.Observation,
                        consultation.Diagnostic);
                }
            }
        }



    }
}

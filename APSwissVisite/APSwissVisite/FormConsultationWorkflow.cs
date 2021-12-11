using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSwissVisite
{
    public partial class FormConsultationWorkflow : Form
    {
        public static FormConsultationWorkflow Current;
        public FormConsultationWorkflow()
        {
            InitializeComponent();
            if (Current == null) Current = this;
        }
        public void UpdateCB()
        {
            CbMedicaments.Items.Clear();
            foreach (Medicament M in Globale.Medicaments.Values)
                CbMedicaments.Items.Add(M.DepotLegal);
            CbMedicaments.SelectedIndex = 0;
        }

        private void FormConsultationWorkflow_Load(object sender, EventArgs e) => UpdateCB();

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            LvEtapes.Items.Clear();
            List<Workflow> lesEtapes = Globale.Medicaments[CbMedicaments.Text].LesEtapes;
            if (lesEtapes is null)
            {
                MessageBox.Show("Ce médicament n'a pas de workflow", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Workflow W in lesEtapes)
            {
                int numEtape = W.NumEtape;
                Etape etape = Globale.Etapes[numEtape];
                ListViewItem ligne = new ListViewItem() { Text = numEtape.ToString() };
                ligne.SubItems.Add(etape.Libelle);
                ligne.SubItems.Add(W.DateDecison.Date.ToString());
                ligne.SubItems.Add(Globale.Decisions[W.IdDecision].Libelle);
                if (etape.GetType() == typeof(EtapeNormee))
                {
                    EtapeNormee etapeNormee = (EtapeNormee)etape;
                    ligne.SubItems.Add(etapeNormee.Norme);
                    ligne.SubItems.Add(etapeNormee.Date.Date.ToString());
                }
                LvEtapes.Items.Add(ligne);
            }
        }

        private void FormConsultationWorkflow_FormClosing(object sender, FormClosingEventArgs e) => Current = null;
    }
}

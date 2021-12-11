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
            foreach (Medicament M in Globale.lesMedicaments.Values)
                CbMedicaments.Items.Add(M.getDepotLegale());
            CbMedicaments.SelectedIndex = 0;
        }

        private void FormConsultationWorkflow_Load(object sender, EventArgs e)
        {
            UpdateCB();
        }

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            LvEtapes.Items.Clear();
            List<Workflow> lesEtapes = Globale.lesMedicaments[CbMedicaments.Text].LesEtapes;
            if (lesEtapes is null)
            {
                MessageBox.Show("Ce médicament n'a pas de workflow", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Workflow W in lesEtapes)
            {
                int numEtape = W.getNum();
                Etape etape = Globale.lesEtapes[numEtape];
                ListViewItem ligne = new ListViewItem() { Text = numEtape.ToString() };
                ligne.SubItems.Add(etape.getLibelle());
                ligne.SubItems.Add(W.getDate().Date.ToString());
                ligne.SubItems.Add(Decision.LesDecisions[W.IdDecision].Libelle);
                if (etape.GetType() == typeof(EtapeNormee))
                {
                    EtapeNormee etapeNormee = (EtapeNormee)etape;
                    ligne.SubItems.Add(etapeNormee.getNorme());
                    ligne.SubItems.Add(etapeNormee.getDateNorme().Date.ToString());
                }
                LvEtapes.Items.Add(ligne);
            }
        }
    }
}

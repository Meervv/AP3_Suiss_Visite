using System;
using System.Windows.Forms;
using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchEtapes();
            FetchFamilles();
            FetchDecisions();
            FetchMedicaments();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_etapes_normees newFrm = new frm_etapes_normees();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void listeÉtapesNorméesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultation_medicament newFrm = new frm_consultation_medicament();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMedicament newFrm = new AjoutMedicament();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void médicamentEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultationMédicamentEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encours newFrm = new Encours();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void consultationDesWorkflowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormConsultationWorkflow.Current != null) return;
            new FormConsultationWorkflow() { MdiParent = this, WindowState = FormWindowState.Maximized}.Show();
        }

        private void saisieDécisionÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormSaisieDecisionEtape.CurrentForm != null) return;
            new FormSaisieDecisionEtape() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }
    }
}

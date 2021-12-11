using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static APSwissVisite.SQL_tristan;
using static APSwissVisite.SQL_marvine;
using static APSwissVisite.SQL_yohann;

namespace APSwissVisite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchEtapes();
            afficherFamille();
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
            Encoure newFrm = new Encoure();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void consultationDesWorkflowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultationWorkflow newFrm = new FormConsultationWorkflow();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void saisieDécisionÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaisieDecisionEtape newFrm = new FormSaisieDecisionEtape();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }
    }
}

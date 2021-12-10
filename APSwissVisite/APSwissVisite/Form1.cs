using System;
using System.Windows.Forms;
using System.Text;
using static APSwissVisite.SQL;

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
            FetchFamilles();
            FetchMedicaments();
            FetchDecisions();
            FetchEtapes();
        }

        private void button1_Click(object sender, EventArgs e) => new FormSaisieDecisionEtape().Show();

        private void button2_Click(object sender, EventArgs e) => new FormConsultationWorkflow().Show();
    }
}

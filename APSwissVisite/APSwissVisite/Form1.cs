using System;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            FetchFamille();
            //// FetchDecisions();
            FetchMedicaments();
            FetchDecision();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutMedicament form = new AjoutMedicament();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encoure form = new Encoure();
            form.Show();
            Hide();
        }
    }
}

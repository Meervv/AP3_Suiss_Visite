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
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = "Data Source=BTS2020-17\\SQLEXPRESS;Initial Catalog=;Integrated Security=True;MultipleActiveResultSets=True";
            globale.cnx.Open();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_etapes_normees newFrm = new frm_etapes_normees();
            newFrm.MdiParent = this;
            WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }
    }
}

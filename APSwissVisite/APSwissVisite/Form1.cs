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
    }
}

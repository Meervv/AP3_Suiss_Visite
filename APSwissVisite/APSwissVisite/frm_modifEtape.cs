using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class frm_modifEtape : Form
    {
        public int index;
        public frm_modifEtape(int idx, string norm, string date)
        {
            InitializeComponent();
            tbNorme.Text = norm;
            tbDate.Text = date;
            index = idx;
        }
        private void frm_modifEtape_Load(object sender, EventArgs e)
        {
            
        }

        public void addInHistorique()
        {

        }
        private void btModif_Click(object sender, EventArgs e)
        {
            const string message = "Voulez-vous vraiment modifier l'étape normée ?";

            var result = MessageBox.Show(message, "Fermeture de la forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                updateEtape(tbNorme.Text, DateTime.Parse(tbDate.Text), index);
                addInHistorique();
                this.Close();
            }
        }
    }
}

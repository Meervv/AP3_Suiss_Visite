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
    public partial class frm_etapes_normees : Form
    {
        public frm_etapes_normees()
        {
            InitializeComponent();
        }

        private void chargerListe()
        {
            lvEtapeNormee.Items.Clear();

            SQL.lireLesEtapes();

            foreach (Etape lEtape in Globale.lesEtapes)
            {
                if (lEtape.GetType() == typeof(EtapeNormee)) //check le type de la class
                {
                    EtapeNormee etape = (EtapeNormee)lEtape;
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = etape.getNum().ToString();
                    ligne.SubItems.Add(etape.getLibelle());
                    ligne.SubItems.Add(etape.getNorme());
                    lvEtapeNormee.Items.Add(ligne);
                }
            }
        }
        private void frm_etapes_normees_Load(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEtapeNormee.SelectedIndices.Count <= 0)
            {
                return;
            }
            int idx = lvEtapeNormee.SelectedIndices[0];
            
            if (idx >= 0)
            {
                string res = lvEtapeNormee.Items[idx].Text;
                frm_modifEtape newFrm = new frm_modifEtape();
                WindowState = FormWindowState.Maximized;
                newFrm.Show();
            }
        }
    }
}

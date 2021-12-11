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
            foreach (Etape lEtape in Globale.lesEtapes)
            {
                if (lEtape != null && lEtape.GetType() == typeof(EtapeNormee))
                {
                    EtapeNormee etape = (EtapeNormee)lEtape;
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = etape.getNum().ToString();
                    ligne.SubItems.Add(etape.getLibelle());
                    ligne.SubItems.Add(etape.getNorme());
                    ligne.SubItems.Add(etape.getDateNorme().ToString());
                    lvEtapeNormee.Items.Add(ligne);
                }
            }
        }
        private void frm_etapes_normees_Load(object sender, EventArgs e)
        {
            lvEtapeNormee.Items.Clear();
            chargerListe();
            SQL_marvine.lireLesEtapes();
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
                string norm = lvEtapeNormee.Items[idx].SubItems[2].Text;
                string date = lvEtapeNormee.Items[idx].SubItems[3].Text;
                int index = int.Parse(lvEtapeNormee.Items[idx].SubItems[0].Text);
                frm_modifEtape newFrm = new frm_modifEtape(index, norm, date);
                newFrm.TopMost = true;
                newFrm.Show();
            }
        }
    }
}

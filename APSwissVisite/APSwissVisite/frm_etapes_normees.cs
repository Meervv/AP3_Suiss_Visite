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

            foreach(Etape lEtape in Globale.lesEtapes)
            {
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = lEtape.getNum().ToString();
                maLigne.SubItems.Add(lEtape.getLibelle());
                maLigne.SubItems.Add("");
                lvEtapeNormee.Items.Add(maLigne);
            }

        }
        private void frm_etapes_normees_Load(object sender, EventArgs e)
        {
            chargerListe();
        }
    }
}

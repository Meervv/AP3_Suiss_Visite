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
    public partial class frm_consultation_medicament : Form
    {
        public frm_consultation_medicament()
        {
            InitializeComponent();
        }

        private void frm_consultation_medicament_Load(object sender, EventArgs e)
        {
            lvListeNombre.Items.Clear();
            SQL.afficherFamille();
        }

        public void afficherListe()
        {
            Dictionary<string, Famille>.KeyCollection lesCles = Globale.lesFamilles.Keys;

            foreach (string leCode in lesCles)
            {
                Famille uneFamille = Globale.lesFamilles[leCode];

                ListViewItem ligne = new ListViewItem();
                ligne.Text = uneFamille.getCode();
                ligne.SubItems.Add(uneFamille.getLibelle());
                ligne.SubItems.Add(uneFamille.getNbMedicamentAmm().ToString());

                lvListeNombre.Items.Add(ligne);
            }
        }
    }
}

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
            afficherListe();
        }

        public void afficherListe()
        {
            Dictionary<string, Famille>.KeyCollection lesCles = Globale.Familles.Keys;

            foreach (string leCode in lesCles)
            {
                Famille uneFamille = Globale.Familles[leCode];

                ListViewItem ligne = new ListViewItem();
                ligne.Text = uneFamille.Code;
                ligne.SubItems.Add(uneFamille.Libelle);
                ligne.SubItems.Add(uneFamille.NbMedicamentAmm.ToString());

                lvListeNombre.Items.Add(ligne);
            }
        }

        private void lvListeNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMedicaments.Items.Clear();
            if (lvListeNombre.SelectedIndices.Count <= 0)
                return;
            int idx = lvListeNombre.SelectedIndices[0];
            if (idx >= 0)
            {
                foreach (Medicament leMedicament in SQL.GetFamilleMedicaments(lvListeNombre.Items[idx].SubItems[0].Text))
                {
                    if (lvListeNombre.Items[idx].SubItems[0].Text == leMedicament.Famille.Code)
                    {
                        ListViewItem ligne = new ListViewItem();

                        ligne.Text = leMedicament.DepotLegal;
                        ligne.SubItems.Add(leMedicament.NomCommercial);
                        ligne.SubItems.Add(leMedicament.Composition);
                        ligne.SubItems.Add(leMedicament.Effets);
                        ligne.SubItems.Add(leMedicament.ContreIndications);
                        ligne.SubItems.Add(leMedicament.Famille.Code);
                        lvMedicaments.Items.Add(ligne);
                    }
                }
            }
        }

        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

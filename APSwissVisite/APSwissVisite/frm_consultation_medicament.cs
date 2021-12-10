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
            SQL.afficherFamille(); //rechercher la fonction SQL
            afficherListe();
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

        private void lvListeNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMedicaments.Items.Clear();
            if (lvListeNombre.SelectedIndices.Count <= 0)
                return;
            int idx = lvListeNombre.SelectedIndices[0];
            if (idx >= 0)
            {
                foreach (Medicament leMedicament in SQL.afficherMedicaments(lvListeNombre.Items[idx].SubItems[0].Text))
                {
                    if (lvListeNombre.Items[idx].SubItems[0].Text == leMedicament.getLaFamille().getCode())
                    {
                        ListViewItem ligne = new ListViewItem();

                        ligne.Text = leMedicament.getDepotLegale();
                        ligne.SubItems.Add(leMedicament.getNom());
                        ligne.SubItems.Add(leMedicament.getCompo());
                        ligne.SubItems.Add(leMedicament.getEffets());
                        ligne.SubItems.Add(leMedicament.getContreIndic());
                        ligne.SubItems.Add(leMedicament.getLaFamille().getCode());
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

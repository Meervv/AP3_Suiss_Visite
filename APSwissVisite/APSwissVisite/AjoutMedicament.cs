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
    public partial class AjoutMedicament : Form
    {
        public AjoutMedicament()
        {
            InitializeComponent();
        }

        private void AjoutMedicament_Load(object sender, EventArgs e)
        {
            SQL_marvine.afficherFamille();
            Dictionary<string, Famille>.KeyCollection lesCles = Globale.lesFamilles.Keys;
            foreach (string leCode in lesCles)
            {
                Famille uneFamille = Globale.lesFamilles[leCode];

                cbCodeFamille.Items.Add(uneFamille.getCode().ToString());
            }
            /*foreach (Famille f in Famille.LesFamilles.Values)
            {
                cbCodeFamille.Items.Add(f.getCode());
            }*/
        }

        private void cbAjout_Click(object sender, EventArgs e)
        {
            int idx = 0;
            Boolean trouve = false;
            while (idx < Globale.lesMedicaments.Count && !trouve)
            {
                Medicament M = Globale.lesMedicaments.Values.ElementAt(idx);
                if (M.getDepotLegale() == tbDepotLegal.Text)
                {
                    trouve = true;
                }
                else
                    idx++;
            }
            if (trouve)
            {
                MessageBox.Show("il ne peut pas y avoir 2 fois le même depot legal");
                return;
            }

            SQL_tristan.AjoutMedicament(tbDepotLegal.Text, tbNomCommercial.Text, cbCodeFamille.Text, float.Parse(tbPrixEchantillon.Text), rtbCompoMed.Text, rtbEffetMed.Text, rtbContreIndic.Text);
            MessageBox.Show("le medicament à été ajouter");
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Close();
        }
    }
}

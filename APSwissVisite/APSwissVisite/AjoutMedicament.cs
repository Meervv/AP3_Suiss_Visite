using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static APSwissVisite.SQL;

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
            Dictionary<string, Famille>.KeyCollection lesCles = Globale.Familles.Keys;
            foreach (string leCode in lesCles)
            {
                Famille uneFamille = Globale.Familles[leCode];

                cbCodeFamille.Items.Add(uneFamille.Code);
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
            while (idx < Globale.Medicaments.Count && !trouve)
            {
                Medicament M = Globale.Medicaments.Values.ElementAt(idx);
                if (M.DepotLegal == tbDepotLegal.Text)
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

            AjoutMedicament(tbDepotLegal.Text, tbNomCommercial.Text, cbCodeFamille.Text, float.Parse(tbPrixEchantillon.Text), rtbCompoMed.Text, rtbEffetMed.Text, rtbContreIndic.Text);
            MessageBox.Show("le medicament à été ajouter");
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            Close();
        }
    }
}

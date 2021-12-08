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
    public partial class AjoutMedicament : Form
    {
        public AjoutMedicament()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AjoutMedicament_Load(object sender, EventArgs e)
        {
            
            FetchFamille();
            FetchMedicaments();
            foreach (Famille f in Famille.LesFamilles.Values)
            {
                cbCodeFamille.Items.Add(f.Code);
            }
        }

        private void cbAjout_Click(object sender, EventArgs e)
        {
            int idx = 0;
            Boolean trouve = false;
            while (idx < Medicament.LesMedicaments.Count && !trouve)
            {
                Medicament M = Medicament.LesMedicaments.Values.ElementAt(idx);
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

            SQL.AjoutMedicament(tbDepotLegal.Text, tbNomCommercial.Text, cbCodeFamille.Text, float.Parse(tbPrixEchantillon.Text), rtbCompoMed.Text, rtbEffetMed.Text, rtbContreIndic.Text);
            MessageBox.Show("le medicament à été ajouter");
        }

        private void tbDepotLegal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
    }
}

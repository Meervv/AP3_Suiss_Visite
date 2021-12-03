using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class Encoure : Form
    {
        public Encoure()
        {
            InitializeComponent();
        }

        private void Encoure_Load(object sender, EventArgs e)
        {

            gbWorkflow.Visible = false;
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_afficher_med_encoure", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                ListViewItem uneLigne = new ListViewItem();
                uneLigne.Text = result.GetValue(0).ToString();
                for (int i = 1; i < result.FieldCount; i++)
                {
                    uneLigne.SubItems.Add(result.GetValue(i).ToString());
                }
                lvEncourec.Items.Add(uneLigne);
            }

            Connexion.Close();

        }

        private void lvEncourec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEncourec.SelectedItems.Count == 0)
                return;
            gbWorkflow.Visible = true;
            lvWorkflow.Items.Clear();
            string depot = lvEncourec.SelectedItems[0].Text;
            ListViewItem uneLigne = new ListViewItem();
        
            for(int i = 0; i < Medicament.LesMedicaments[depot].LesEtapes.Count; i++)
            {
                uneLigne.Text = Medicament.LesMedicaments[depot].LesEtapes[i].DateDecison.Date.ToString("dd-MM-yyyy");
                uneLigne.SubItems.Add(Medicament.LesMedicaments[depot].LesEtapes[i].NumEtape.ToString());
                //uneLigne.SubItems.Add(Decision.LesDecisions[Medicament.LesMedicaments[depot].LesEtapes[0].IdDecision].Libelle);
                if(Medicament.LesMedicaments[depot].LesEtapes[i].IdDecision.ToString() == Decision.LesDecisions[i].ID.ToString())
                    uneLigne.SubItems.Add(Decision.LesDecisions[i].Libelle.ToString());
                lvWorkflow.Items.Add(uneLigne);
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbWorkflow_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
    }
}

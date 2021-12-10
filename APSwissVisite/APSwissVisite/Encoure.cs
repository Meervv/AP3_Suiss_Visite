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
using static APSwissVisite.SQL_tristan;

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

        private void btRetour_Click(object sender, EventArgs e)
        {

        }

        private void lvEncourec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEncourec.SelectedItems.Count == 0)
                return;
            lvWorkflow.Items.Clear();
            string depot = lvEncourec.SelectedItems[0].Text;

            for (int i = 0; i < Globale.lesMedicaments[depot].LesEtapes.Count; i++)
            {
                ListViewItem uneLigne = new ListViewItem();
                uneLigne.Text = Globale.lesMedicaments[depot].LesEtapes[i].DateDecison.Date.ToString("dd-MM-yyyy");
                uneLigne.SubItems.Add(Globale.lesMedicaments[depot].LesEtapes[i].NumEtape.ToString());
                //uneLigne.SubItems.Add(Decision.LesDecisions[Medicament.LesMedicaments[depot].LesEtapes[0].IdDecision].Libelle);
                if (Globale.lesMedicaments[depot].LesEtapes[i].IdDecision.ToString() == Decision.LesDecisions[i].ID.ToString())
                    uneLigne.SubItems.Add(Decision.LesDecisions[i].Libelle.ToString());
                lvWorkflow.Items.Add(uneLigne);
            }
        }
    }
}

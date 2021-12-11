using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class Encours : Form
    {
        public Encours()
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

            for (int i = 0; i < Globale.Medicaments[depot].LesEtapes.Count; i++)
            {
                ListViewItem uneLigne = new ListViewItem();
                uneLigne.Text = Globale.Medicaments[depot].LesEtapes[i].DateDecison.Date.ToString("dd-MM-yyyy");
                uneLigne.SubItems.Add(Globale.Medicaments[depot].LesEtapes[i].NumEtape.ToString());
                //uneLigne.SubItems.Add(Decision.LesDecisions[Medicament.LesMedicaments[depot].LesEtapes[0].IdDecision].Libelle);
                if (Globale.Medicaments[depot].LesEtapes[i].IdDecision.ToString() == Globale.Decisions[i].ID.ToString())
                    uneLigne.SubItems.Add(Globale.Decisions[i].Libelle.ToString());
                lvWorkflow.Items.Add(uneLigne);
            }
        }
    }
}

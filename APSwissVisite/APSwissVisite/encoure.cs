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
    }
}

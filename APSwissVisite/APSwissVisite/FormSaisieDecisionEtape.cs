using System;
using System.Windows.Forms;
using System.Drawing;
using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class FormSaisieDecisionEtape : Form
    {
        internal Medicament Current; // Médicament actuellement sélectionné

        public FormSaisieDecisionEtape()
        {
            InitializeComponent();
        }

        #region Local Subroutines

        private void UpdatelastEtape()
        {
            //TbLastEtapeNum.Text = 
        }

        #endregion

        #region Form Subroutines
        private void FormSaisieDecisionEtape_Load(object sender, EventArgs e)
        {
            foreach (Medicament M in Medicament.LesMedicaments.Values)
                CbMedicaments.Items.Add(M.DepotLegal);
        }

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current = Medicament.LesMedicaments[CbMedicaments.Text];
            TbNomCommercial.Text = Current.NomCommercial;
            if (IsMedicamentValid(Current))
            {
                GbLastEtape.Visible = true;
                //LblMedicState.Location = new Point(447, 103); Relative coords:(
                LblMedicState.Text = "VALIDE";
                LblMedicState.ForeColor = Color.Green;
            }
            else
            {
                GbLastEtape.Visible = false;
                //LblMedicState.Location = new Point(435, 103);
                LblMedicState.Text = "INVALIDE";
                LblMedicState.ForeColor = Color.Red;
            }
        }
        #endregion
    }
}

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
            Etape lastEtape = Etape.LesEtapes[Current.DerniereEtape.NumEtape];
            if (lastEtape.GetType() == typeof(EtapeNormee))
            {
                EtapeNormee etapeNorme = (EtapeNormee)lastEtape;
                TbLastEtapeNomNorme.Text = etapeNorme.Norme;
                TbLastEtapeNormeDate.Text = etapeNorme.Date.Date.ToString();
            }
            TbLastEtapeNum.Text = lastEtape.Num.ToString();
            TbLastEtapeLibelle.Text = lastEtape.Libelle;
            TbLastEtapeDate.Text = Current.DerniereEtape.DateDecision.Date.ToString();
        }

        private void UpdateCB()
        {
            CbMedicaments.Items.Clear();
            foreach (Medicament M in Medicament.LesMedicaments.Values)
                CbMedicaments.Items.Add(M.DepotLegal);
        }

        #endregion

        #region Form Subroutines
        private void FormSaisieDecisionEtape_Load(object sender, EventArgs e) => UpdateCB();

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current = Medicament.LesMedicaments[CbMedicaments.Text];
            TbNomCommercial.Text = Current.NomCommercial;
            if (Current.DerniereEtape.IdDecision == 1)
            {
                GbLastEtape.Visible = true;
                GbNextEtape.Visible = true;
                //LblMedicState.Location = new Point(447, 103); Relative coords:(
                LblMedicState.Text = "VALIDE";
                LblMedicState.ForeColor = Color.Green;
                UpdatelastEtape();
            }
            else
            {
                GbLastEtape.Visible = false;
                GbNextEtape.Visible = false;
                //LblMedicState.Location = new Point(435, 103);
                LblMedicState.Text = "INVALIDE";
                LblMedicState.ForeColor = Color.Red;
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            MedicamentUpdateLastEtape(Current, RbValide.Checked, DtpDateDecision.Value);
            UpdateCB();
        }
        #endregion
    }
}

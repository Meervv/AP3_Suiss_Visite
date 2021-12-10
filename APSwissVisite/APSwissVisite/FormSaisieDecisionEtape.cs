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

        #region Custom Subroutines

        private void UpdateCB()
        {
            int idx = 0;
            if (CbMedicaments.Items.Count != 0) idx = Medicament.LesMedicaments[CbMedicaments.Text].DerniereEtape.NumEtape == 8 ? 0 : CbMedicaments.SelectedIndex;
            CbMedicaments.Items.Clear();
            foreach (Medicament M in Medicament.LesMedicaments.Values)
            {
                if (M.DerniereEtape is null) CbMedicaments.Items.Add(M.DepotLegal);
                else if (M.DerniereEtape.NumEtape != 8) CbMedicaments.Items.Add(M.DepotLegal);
            }
            if (CbMedicaments.Items.Count == 0)
                MessageBox.Show("Plus aucun médicament n'est disponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                CbMedicaments.SelectedIndex = idx;
        }

        private void UpdateLastEtape(bool isNull = false)
        {
            if (isNull)
            {
                TbLastEtapeNum.Text = TbLastEtapeLibelle.Text = TbLastEtapeDate.Text = TbLastEtapeNomNorme.Text = TbLastEtapeNormeDate.Text = string.Empty;
                return;
            }
            Etape lastEtape = Etape.LesEtapes[Current.DerniereEtape.NumEtape];
            if (lastEtape.GetType() == typeof(EtapeNormee))
            {
                EtapeNormee etapeNorme = (EtapeNormee)lastEtape;
                TbLastEtapeNomNorme.Text = etapeNorme.Norme;
                TbLastEtapeNormeDate.Text = etapeNorme.Date.Date.ToString();
            }
            else TbLastEtapeNomNorme.Text = TbLastEtapeNormeDate.Text = string.Empty;
            TbLastEtapeNum.Text = lastEtape.Num.ToString();
            TbLastEtapeLibelle.Text = lastEtape.Libelle;
            TbLastEtapeDate.Text = Current.DerniereEtape.DateDecision.Date.ToString();
        }

        private void UpdateNextEtape()
        {
            Workflow lastWorkflow = Current.DerniereEtape;
            Etape nextEtape;
            if (lastWorkflow is null) nextEtape = Etape.LesEtapes[1];
            else nextEtape = Etape.LesEtapes[Current.DerniereEtape.NumEtape + 1];
            if (nextEtape.GetType() == typeof(EtapeNormee))
            {
                EtapeNormee etapeNorme = (EtapeNormee)nextEtape;
                TbNextEtapeNomNorme.Text = etapeNorme.Norme;
                TbNextEtapeDateNorme.Text = etapeNorme.Date.Date.ToString();
            }
            else TbNextEtapeNomNorme.Text = TbNextEtapeDateNorme.Text = string.Empty;
            TbNextEtapeNum.Text = nextEtape.Num.ToString();
            TbNextEtapeLibelle.Text = nextEtape.Libelle;
        }

        #endregion

        #region Form Subroutines
        private void FormSaisieDecisionEtape_Load(object sender, EventArgs e) => UpdateCB();

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current = Medicament.LesMedicaments[CbMedicaments.Text];
            TbNomCommercial.Text = Current.NomCommercial;
            Workflow lastWorklow = Current.DerniereEtape;
            if (lastWorklow is null)
            { 
                UpdateLastEtape(true);
                UpdateNextEtape();
                return;
            }
            if (Current.DerniereEtape.IdDecision == 1)
            {
                GbLastEtape.Visible = true;
                GbNextEtape.Visible = true;
                //LblMedicState.Location = new Point(447, 103); Relative coords :(
                LblMedicState.Text = "VALIDE";
                LblMedicState.ForeColor = Color.Green;
                UpdateLastEtape();
                UpdateNextEtape();
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
            MessageBox.Show("Le médicament à bien été mis à jour", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateCB();
            FormConsultationWorkflow.Current?.UpdateCB();
        }
        #endregion
    }
}

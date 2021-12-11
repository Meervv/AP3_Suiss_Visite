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
    public partial class FormSaisieDecisionEtape : Form
    {
        internal Medicament Current; // Médicament actuellement sélectionné
        public FormSaisieDecisionEtape()
        {
            InitializeComponent();
        }

        private void FormSaisieDecisionEtape_Load(object sender, EventArgs e)
        {
            UpdateCB();
        }

        private void CbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current = Globale.lesMedicaments[CbMedicaments.Text];
            TbNomCommercial.Text = Current.getNom();
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
                LblMedicState.Text = "VALIDE";
                LblMedicState.ForeColor = Color.Green;
                UpdateLastEtape();
                UpdateNextEtape();
            }
            else
            {
                GbLastEtape.Visible = false;
                GbNextEtape.Visible = false;
                LblMedicState.Text = "INVALIDE";
                LblMedicState.ForeColor = Color.Red;
            }
        }
        private void UpdateCB()
        {
            int idx = 0;
            if (CbMedicaments.Items.Count != 0) idx = Globale.lesMedicaments[CbMedicaments.Text].DerniereEtape.NumEtape == 8 ? 0 : CbMedicaments.SelectedIndex;
            CbMedicaments.Items.Clear();
            foreach (Medicament M in Globale.lesMedicaments.Values)
            {
                if (M.DerniereEtape is null) CbMedicaments.Items.Add(M.getDepotLegale());
                else if (M.DerniereEtape.NumEtape != 8) CbMedicaments.Items.Add(M.getDepotLegale());
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
            MessageBox.Show(Current.DerniereEtape.NumEtape.ToString());
            Etape lastEtape = Globale.lesEtapes[Current.DerniereEtape.NumEtape];
            if (lastEtape.GetType() == typeof(EtapeNormee))
            {
                EtapeNormee etapeNorme = (EtapeNormee)lastEtape;
                TbLastEtapeNomNorme.Text = etapeNorme.getNorme();
                TbLastEtapeNormeDate.Text = etapeNorme.getDateNorme().Date.ToString();
            }
            else TbLastEtapeNomNorme.Text = TbLastEtapeNormeDate.Text = string.Empty;
            TbLastEtapeNum.Text = lastEtape.getNum().ToString();
            TbLastEtapeLibelle.Text = lastEtape.getLibelle();
            TbLastEtapeDate.Text = Current.DerniereEtape.getDate().Date.ToString();
        }

        private void UpdateNextEtape()
        {
            Workflow lastWorkflow = Current.DerniereEtape;
            Etape nextEtape;
            if (lastWorkflow is null) nextEtape = Globale.lesEtapes[1];
            else nextEtape = Globale.lesEtapes[Current.DerniereEtape.NumEtape + 1];
            if (nextEtape.GetType() == typeof(EtapeNormee))
            {
                EtapeNormee etapeNorme = (EtapeNormee)nextEtape;
                TbNextEtapeNomNorme.Text = etapeNorme.getNorme();
                TbNextEtapeDateNorme.Text = etapeNorme.getDateNorme().Date.ToString();
            }
            else TbNextEtapeNomNorme.Text = TbNextEtapeDateNorme.Text = string.Empty;
            TbNextEtapeNum.Text = nextEtape.getNum().ToString();
            TbNextEtapeLibelle.Text = nextEtape.getLibelle();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            SQL_yohann.MedicamentUpdateLastEtape(Current, RbValide.Checked, DtpDateDecision.Value);
            MessageBox.Show("Le médicament à bien été mis à jour", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateCB();
            FormConsultationWorkflow.Current?.UpdateCB();
        }
    }
}

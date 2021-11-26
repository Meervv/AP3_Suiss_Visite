
namespace APSwissVisite
{
    partial class FormSaisieDecisionEtape
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbMedicaments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNomCommercial = new System.Windows.Forms.TextBox();
            this.GbMedic = new System.Windows.Forms.GroupBox();
            this.LblMedicState = new System.Windows.Forms.Label();
            this.GbLastEtape = new System.Windows.Forms.GroupBox();
            this.TbLastEtapeNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbLastEtapeDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbLastEtapeLibelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbLastEtapeStandardDate = new System.Windows.Forms.TextBox();
            this.TbLastEtapeStandardName = new System.Windows.Forms.TextBox();
            this.GbMedic.SuspendLayout();
            this.GbLastEtape.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbMedicaments
            // 
            this.CbMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMedicaments.FormattingEnabled = true;
            this.CbMedicaments.Location = new System.Drawing.Point(159, 52);
            this.CbMedicaments.Name = "CbMedicaments";
            this.CbMedicaments.Size = new System.Drawing.Size(134, 24);
            this.CbMedicaments.TabIndex = 0;
            this.CbMedicaments.SelectedIndexChanged += new System.EventHandler(this.CbMedicaments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statut du médicament :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Commercial :";
            // 
            // TbNomCommercial
            // 
            this.TbNomCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomCommercial.Location = new System.Drawing.Point(28, 141);
            this.TbNomCommercial.Name = "TbNomCommercial";
            this.TbNomCommercial.ReadOnly = true;
            this.TbNomCommercial.Size = new System.Drawing.Size(265, 22);
            this.TbNomCommercial.TabIndex = 6;
            this.TbNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GbMedic
            // 
            this.GbMedic.Controls.Add(this.LblMedicState);
            this.GbMedic.Controls.Add(this.CbMedicaments);
            this.GbMedic.Controls.Add(this.TbNomCommercial);
            this.GbMedic.Controls.Add(this.label3);
            this.GbMedic.Controls.Add(this.label1);
            this.GbMedic.Controls.Add(this.label2);
            this.GbMedic.Location = new System.Drawing.Point(12, 12);
            this.GbMedic.Name = "GbMedic";
            this.GbMedic.Size = new System.Drawing.Size(666, 189);
            this.GbMedic.TabIndex = 7;
            this.GbMedic.TabStop = false;
            this.GbMedic.Text = "Médicament";
            // 
            // LblMedicState
            // 
            this.LblMedicState.AutoSize = true;
            this.LblMedicState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicState.Location = new System.Drawing.Point(435, 103);
            this.LblMedicState.Name = "LblMedicState";
            this.LblMedicState.Size = new System.Drawing.Size(0, 25);
            this.LblMedicState.TabIndex = 7;
            // 
            // GbLastEtape
            // 
            this.GbLastEtape.Controls.Add(this.TbLastEtapeStandardDate);
            this.GbLastEtape.Controls.Add(this.TbLastEtapeStandardName);
            this.GbLastEtape.Controls.Add(this.label8);
            this.GbLastEtape.Controls.Add(this.label7);
            this.GbLastEtape.Controls.Add(this.TbLastEtapeLibelle);
            this.GbLastEtape.Controls.Add(this.label6);
            this.GbLastEtape.Controls.Add(this.TbLastEtapeDate);
            this.GbLastEtape.Controls.Add(this.label5);
            this.GbLastEtape.Controls.Add(this.TbLastEtapeNum);
            this.GbLastEtape.Controls.Add(this.label4);
            this.GbLastEtape.Location = new System.Drawing.Point(12, 229);
            this.GbLastEtape.Name = "GbLastEtape";
            this.GbLastEtape.Size = new System.Drawing.Size(844, 153);
            this.GbLastEtape.TabIndex = 8;
            this.GbLastEtape.TabStop = false;
            this.GbLastEtape.Text = "Dernière étape";
            this.GbLastEtape.Visible = false;
            // 
            // TbLastEtapeNum
            // 
            this.TbLastEtapeNum.Location = new System.Drawing.Point(118, 42);
            this.TbLastEtapeNum.Name = "TbLastEtapeNum";
            this.TbLastEtapeNum.ReadOnly = true;
            this.TbLastEtapeNum.Size = new System.Drawing.Size(87, 22);
            this.TbLastEtapeNum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numéro :";
            // 
            // TbLastEtapeDate
            // 
            this.TbLastEtapeDate.Location = new System.Drawing.Point(118, 99);
            this.TbLastEtapeDate.Name = "TbLastEtapeDate";
            this.TbLastEtapeDate.ReadOnly = true;
            this.TbLastEtapeDate.Size = new System.Drawing.Size(87, 22);
            this.TbLastEtapeDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Libellé :";
            // 
            // TbLastEtapeLibelle
            // 
            this.TbLastEtapeLibelle.Location = new System.Drawing.Point(251, 99);
            this.TbLastEtapeLibelle.Name = "TbLastEtapeLibelle";
            this.TbLastEtapeLibelle.ReadOnly = true;
            this.TbLastEtapeLibelle.Size = new System.Drawing.Size(225, 22);
            this.TbLastEtapeLibelle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nom norme :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date norme :";
            // 
            // TbLastEtapeStandardDate
            // 
            this.TbLastEtapeStandardDate.Location = new System.Drawing.Point(677, 99);
            this.TbLastEtapeStandardDate.Name = "TbLastEtapeStandardDate";
            this.TbLastEtapeStandardDate.ReadOnly = true;
            this.TbLastEtapeStandardDate.Size = new System.Drawing.Size(137, 22);
            this.TbLastEtapeStandardDate.TabIndex = 17;
            // 
            // TbLastEtapeStandardName
            // 
            this.TbLastEtapeStandardName.Location = new System.Drawing.Point(677, 44);
            this.TbLastEtapeStandardName.Name = "TbLastEtapeStandardName";
            this.TbLastEtapeStandardName.ReadOnly = true;
            this.TbLastEtapeStandardName.Size = new System.Drawing.Size(137, 22);
            this.TbLastEtapeStandardName.TabIndex = 16;
            // 
            // FormSaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 404);
            this.Controls.Add(this.GbLastEtape);
            this.Controls.Add(this.GbMedic);
            this.Name = "FormSaisieDecisionEtape";
            this.Text = "FormSaisieDecisionEtape";
            this.Load += new System.EventHandler(this.FormSaisieDecisionEtape_Load);
            this.GbMedic.ResumeLayout(false);
            this.GbMedic.PerformLayout();
            this.GbLastEtape.ResumeLayout(false);
            this.GbLastEtape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbMedicaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNomCommercial;
        private System.Windows.Forms.GroupBox GbMedic;
        private System.Windows.Forms.Label LblMedicState;
        private System.Windows.Forms.GroupBox GbLastEtape;
        private System.Windows.Forms.TextBox TbLastEtapeNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbLastEtapeLibelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbLastEtapeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbLastEtapeStandardDate;
        private System.Windows.Forms.TextBox TbLastEtapeStandardName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
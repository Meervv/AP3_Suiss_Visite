
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
            this.TbLastEtapeNormeDate = new System.Windows.Forms.TextBox();
            this.TbLastEtapeNomNorme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbLastEtapeLibelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbLastEtapeDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbLastEtapeNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GbNextEtape = new System.Windows.Forms.GroupBox();
            this.DtpDateDecision = new System.Windows.Forms.DateTimePicker();
            this.TbNextEtapeNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RbRefuse = new System.Windows.Forms.RadioButton();
            this.RbValide = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TbNextEtapeLibelle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TbNextEtapeNomNorme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GbMedic.SuspendLayout();
            this.GbLastEtape.SuspendLayout();
            this.GbNextEtape.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbMedicaments
            // 
            this.CbMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMedicaments.FormattingEnabled = true;
            this.CbMedicaments.Location = new System.Drawing.Point(224, 52);
            this.CbMedicaments.Name = "CbMedicaments";
            this.CbMedicaments.Size = new System.Drawing.Size(204, 24);
            this.CbMedicaments.TabIndex = 0;
            this.CbMedicaments.SelectedIndexChanged += new System.EventHandler(this.CbMedicaments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statut du médicament :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Commercial :";
            // 
            // TbNomCommercial
            // 
            this.TbNomCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomCommercial.Location = new System.Drawing.Point(81, 141);
            this.TbNomCommercial.Name = "TbNomCommercial";
            this.TbNomCommercial.ReadOnly = true;
            this.TbNomCommercial.Size = new System.Drawing.Size(368, 22);
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
            this.GbMedic.Size = new System.Drawing.Size(844, 189);
            this.GbMedic.TabIndex = 7;
            this.GbMedic.TabStop = false;
            this.GbMedic.Text = "Médicament";
            // 
            // LblMedicState
            // 
            this.LblMedicState.AutoSize = true;
            this.LblMedicState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicState.Location = new System.Drawing.Point(611, 103);
            this.LblMedicState.Name = "LblMedicState";
            this.LblMedicState.Size = new System.Drawing.Size(0, 25);
            this.LblMedicState.TabIndex = 7;
            // 
            // GbLastEtape
            // 
            this.GbLastEtape.Controls.Add(this.TbLastEtapeNormeDate);
            this.GbLastEtape.Controls.Add(this.TbLastEtapeNomNorme);
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
            // TbLastEtapeNormeDate
            // 
            this.TbLastEtapeNormeDate.Location = new System.Drawing.Point(618, 99);
            this.TbLastEtapeNormeDate.Name = "TbLastEtapeNormeDate";
            this.TbLastEtapeNormeDate.ReadOnly = true;
            this.TbLastEtapeNormeDate.Size = new System.Drawing.Size(137, 22);
            this.TbLastEtapeNormeDate.TabIndex = 17;
            // 
            // TbLastEtapeNomNorme
            // 
            this.TbLastEtapeNomNorme.Location = new System.Drawing.Point(618, 44);
            this.TbLastEtapeNomNorme.Name = "TbLastEtapeNomNorme";
            this.TbLastEtapeNomNorme.ReadOnly = true;
            this.TbLastEtapeNomNorme.Size = new System.Drawing.Size(137, 22);
            this.TbLastEtapeNomNorme.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date norme :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nom norme :";
            // 
            // TbLastEtapeLibelle
            // 
            this.TbLastEtapeLibelle.Location = new System.Drawing.Point(224, 99);
            this.TbLastEtapeLibelle.Name = "TbLastEtapeLibelle";
            this.TbLastEtapeLibelle.ReadOnly = true;
            this.TbLastEtapeLibelle.Size = new System.Drawing.Size(225, 22);
            this.TbLastEtapeLibelle.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Libellé :";
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
            // GbNextEtape
            // 
            this.GbNextEtape.Controls.Add(this.textBox1);
            this.GbNextEtape.Controls.Add(this.TbNextEtapeNomNorme);
            this.GbNextEtape.Controls.Add(this.label13);
            this.GbNextEtape.Controls.Add(this.label14);
            this.GbNextEtape.Controls.Add(this.TbNextEtapeLibelle);
            this.GbNextEtape.Controls.Add(this.label11);
            this.GbNextEtape.Controls.Add(this.label12);
            this.GbNextEtape.Controls.Add(this.RbValide);
            this.GbNextEtape.Controls.Add(this.RbRefuse);
            this.GbNextEtape.Controls.Add(this.label10);
            this.GbNextEtape.Controls.Add(this.TbNextEtapeNum);
            this.GbNextEtape.Controls.Add(this.label9);
            this.GbNextEtape.Controls.Add(this.DtpDateDecision);
            this.GbNextEtape.Location = new System.Drawing.Point(908, 12);
            this.GbNextEtape.Name = "GbNextEtape";
            this.GbNextEtape.Size = new System.Drawing.Size(396, 370);
            this.GbNextEtape.TabIndex = 9;
            this.GbNextEtape.TabStop = false;
            this.GbNextEtape.Text = "Prochaine étape";
            this.GbNextEtape.Visible = false;
            // 
            // DtpDateDecision
            // 
            this.DtpDateDecision.Location = new System.Drawing.Point(122, 314);
            this.DtpDateDecision.MinDate = new System.DateTime(2021, 12, 1, 15, 31, 54, 0);
            this.DtpDateDecision.Name = "DtpDateDecision";
            this.DtpDateDecision.Size = new System.Drawing.Size(249, 22);
            this.DtpDateDecision.TabIndex = 0;
            this.DtpDateDecision.Value = new System.DateTime(2021, 12, 1, 15, 31, 54, 0);
            // 
            // TbNextEtapeNum
            // 
            this.TbNextEtapeNum.Location = new System.Drawing.Point(110, 52);
            this.TbNextEtapeNum.Name = "TbNextEtapeNum";
            this.TbNextEtapeNum.ReadOnly = true;
            this.TbNextEtapeNum.Size = new System.Drawing.Size(87, 22);
            this.TbNextEtapeNum.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Numéro :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Décision :";
            // 
            // RbRefuse
            // 
            this.RbRefuse.AutoSize = true;
            this.RbRefuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbRefuse.Location = new System.Drawing.Point(122, 233);
            this.RbRefuse.Name = "RbRefuse";
            this.RbRefuse.Size = new System.Drawing.Size(92, 24);
            this.RbRefuse.TabIndex = 13;
            this.RbRefuse.Text = "Refusée";
            this.RbRefuse.UseVisualStyleBackColor = true;
            // 
            // RbValide
            // 
            this.RbValide.AutoSize = true;
            this.RbValide.Checked = true;
            this.RbValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbValide.Location = new System.Drawing.Point(122, 269);
            this.RbValide.Name = "RbValide";
            this.RbValide.Size = new System.Drawing.Size(85, 24);
            this.RbValide.TabIndex = 14;
            this.RbValide.TabStop = true;
            this.RbValide.Text = "Validée";
            this.RbValide.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Date :";
            // 
            // TbNextEtapeLibelle
            // 
            this.TbNextEtapeLibelle.Location = new System.Drawing.Point(110, 101);
            this.TbNextEtapeLibelle.Name = "TbNextEtapeLibelle";
            this.TbNextEtapeLibelle.ReadOnly = true;
            this.TbNextEtapeLibelle.Size = new System.Drawing.Size(225, 22);
            this.TbNextEtapeLibelle.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Libellé :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 23;
            // 
            // TbNextEtapeNomNorme
            // 
            this.TbNextEtapeNomNorme.Location = new System.Drawing.Point(144, 152);
            this.TbNextEtapeNomNorme.Name = "TbNextEtapeNomNorme";
            this.TbNextEtapeNomNorme.ReadOnly = true;
            this.TbNextEtapeNomNorme.Size = new System.Drawing.Size(137, 22);
            this.TbNextEtapeNomNorme.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Date norme :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nom norme :";
            // 
            // FormSaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 473);
            this.Controls.Add(this.GbNextEtape);
            this.Controls.Add(this.GbLastEtape);
            this.Controls.Add(this.GbMedic);
            this.Name = "FormSaisieDecisionEtape";
            this.Text = "FormSaisieDecisionEtape";
            this.Load += new System.EventHandler(this.FormSaisieDecisionEtape_Load);
            this.GbMedic.ResumeLayout(false);
            this.GbMedic.PerformLayout();
            this.GbLastEtape.ResumeLayout(false);
            this.GbLastEtape.PerformLayout();
            this.GbNextEtape.ResumeLayout(false);
            this.GbNextEtape.PerformLayout();
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
        private System.Windows.Forms.TextBox TbLastEtapeNormeDate;
        private System.Windows.Forms.TextBox TbLastEtapeNomNorme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GbNextEtape;
        private System.Windows.Forms.DateTimePicker DtpDateDecision;
        private System.Windows.Forms.RadioButton RbValide;
        private System.Windows.Forms.RadioButton RbRefuse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbNextEtapeNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbNextEtapeLibelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TbNextEtapeNomNorme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
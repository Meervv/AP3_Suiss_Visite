namespace APSwissVisite
{
    partial class AjoutMedicament
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDepotLegal = new System.Windows.Forms.TextBox();
            this.tbNomCommercial = new System.Windows.Forms.TextBox();
            this.tbPrixEchantillon = new System.Windows.Forms.TextBox();
            this.rtbCompoMed = new System.Windows.Forms.RichTextBox();
            this.rtbEffetMed = new System.Windows.Forms.RichTextBox();
            this.rtbContreIndic = new System.Windows.Forms.RichTextBox();
            this.cbCodeFamille = new System.Windows.Forms.ComboBox();
            this.cbAjout = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(108, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dépot légal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom commercial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(108, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code famille :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(552, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Composition du médicament :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(108, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix échantillon médicament :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(634, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contrindications :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(590, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Effets du médicaments :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbDepotLegal
            // 
            this.tbDepotLegal.Font = new System.Drawing.Font("Arial", 9F);
            this.tbDepotLegal.Location = new System.Drawing.Point(204, 96);
            this.tbDepotLegal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDepotLegal.Name = "tbDepotLegal";
            this.tbDepotLegal.Size = new System.Drawing.Size(205, 21);
            this.tbDepotLegal.TabIndex = 8;
            this.tbDepotLegal.TextChanged += new System.EventHandler(this.tbDepotLegal_TextChanged);
            // 
            // tbNomCommercial
            // 
            this.tbNomCommercial.Font = new System.Drawing.Font("Arial", 9F);
            this.tbNomCommercial.Location = new System.Drawing.Point(241, 151);
            this.tbNomCommercial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNomCommercial.Name = "tbNomCommercial";
            this.tbNomCommercial.Size = new System.Drawing.Size(205, 21);
            this.tbNomCommercial.TabIndex = 9;
            // 
            // tbPrixEchantillon
            // 
            this.tbPrixEchantillon.Font = new System.Drawing.Font("Arial", 9F);
            this.tbPrixEchantillon.Location = new System.Drawing.Point(326, 284);
            this.tbPrixEchantillon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPrixEchantillon.Name = "tbPrixEchantillon";
            this.tbPrixEchantillon.Size = new System.Drawing.Size(205, 21);
            this.tbPrixEchantillon.TabIndex = 10;
            // 
            // rtbCompoMed
            // 
            this.rtbCompoMed.Font = new System.Drawing.Font("Arial", 9F);
            this.rtbCompoMed.Location = new System.Drawing.Point(761, 96);
            this.rtbCompoMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbCompoMed.Name = "rtbCompoMed";
            this.rtbCompoMed.Size = new System.Drawing.Size(341, 118);
            this.rtbCompoMed.TabIndex = 11;
            this.rtbCompoMed.Text = "";
            // 
            // rtbEffetMed
            // 
            this.rtbEffetMed.Font = new System.Drawing.Font("Arial", 9F);
            this.rtbEffetMed.Location = new System.Drawing.Point(761, 257);
            this.rtbEffetMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbEffetMed.Name = "rtbEffetMed";
            this.rtbEffetMed.Size = new System.Drawing.Size(341, 156);
            this.rtbEffetMed.TabIndex = 12;
            this.rtbEffetMed.Text = "";
            // 
            // rtbContreIndic
            // 
            this.rtbContreIndic.Font = new System.Drawing.Font("Arial", 9F);
            this.rtbContreIndic.Location = new System.Drawing.Point(761, 443);
            this.rtbContreIndic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbContreIndic.Name = "rtbContreIndic";
            this.rtbContreIndic.Size = new System.Drawing.Size(341, 156);
            this.rtbContreIndic.TabIndex = 13;
            this.rtbContreIndic.Text = "";
            // 
            // cbCodeFamille
            // 
            this.cbCodeFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeFamille.Font = new System.Drawing.Font("Arial", 9F);
            this.cbCodeFamille.FormattingEnabled = true;
            this.cbCodeFamille.Location = new System.Drawing.Point(212, 217);
            this.cbCodeFamille.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCodeFamille.Name = "cbCodeFamille";
            this.cbCodeFamille.Size = new System.Drawing.Size(140, 23);
            this.cbCodeFamille.TabIndex = 14;
            // 
            // cbAjout
            // 
            this.cbAjout.Location = new System.Drawing.Point(112, 482);
            this.cbAjout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAjout.Name = "cbAjout";
            this.cbAjout.Size = new System.Drawing.Size(88, 46);
            this.cbAjout.TabIndex = 16;
            this.cbAjout.Text = "Ajout";
            this.cbAjout.UseVisualStyleBackColor = true;
            this.cbAjout.Click += new System.EventHandler(this.cbAjout_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(241, 481);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 47);
            this.btQuitter.TabIndex = 17;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // AjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1288, 714);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.cbAjout);
            this.Controls.Add(this.cbCodeFamille);
            this.Controls.Add(this.rtbContreIndic);
            this.Controls.Add(this.rtbEffetMed);
            this.Controls.Add(this.rtbCompoMed);
            this.Controls.Add(this.tbPrixEchantillon);
            this.Controls.Add(this.tbNomCommercial);
            this.Controls.Add(this.tbDepotLegal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AjoutMedicament";
            this.Text = "AjoutMedicament";
            this.Load += new System.EventHandler(this.AjoutMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDepotLegal;
        private System.Windows.Forms.TextBox tbNomCommercial;
        private System.Windows.Forms.TextBox tbPrixEchantillon;
        private System.Windows.Forms.RichTextBox rtbCompoMed;
        private System.Windows.Forms.RichTextBox rtbEffetMed;
        private System.Windows.Forms.RichTextBox rtbContreIndic;
        private System.Windows.Forms.ComboBox cbCodeFamille;
        private System.Windows.Forms.Button cbAjout;
        private System.Windows.Forms.Button btQuitter;
    }
}
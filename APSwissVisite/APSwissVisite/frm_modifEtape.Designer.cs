
namespace APSwissVisite
{
    partial class frm_modifEtape
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
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.btModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(196, 103);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(275, 22);
            this.tbDate.TabIndex = 0;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(196, 34);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(275, 22);
            this.tbNorme.TabIndex = 1;
            // 
            // btModif
            // 
            this.btModif.BackColor = System.Drawing.Color.LightCoral;
            this.btModif.ForeColor = System.Drawing.Color.Black;
            this.btModif.Location = new System.Drawing.Point(278, 197);
            this.btModif.Name = "btModif";
            this.btModif.Size = new System.Drawing.Size(82, 31);
            this.btModif.TabIndex = 2;
            this.btModif.Text = "Modifier";
            this.btModif.UseVisualStyleBackColor = false;
            this.btModif.Click += new System.EventHandler(this.btModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modifier la norme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modifier la date :";
            // 
            // frm_modifEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btModif);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.tbDate);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frm_modifEtape";
            this.Text = "Modifier une étape";
            this.Load += new System.EventHandler(this.frm_modifEtape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.Button btModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
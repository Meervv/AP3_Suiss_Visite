
namespace APSwissVisite
{
    partial class frm_consultation_medicament
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
            this.lvListeNombre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvListeNombre
            // 
            this.lvListeNombre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvListeNombre.HideSelection = false;
            this.lvListeNombre.Location = new System.Drawing.Point(12, 35);
            this.lvListeNombre.Name = "lvListeNombre";
            this.lvListeNombre.Size = new System.Drawing.Size(618, 443);
            this.lvListeNombre.TabIndex = 0;
            this.lvListeNombre.UseCompatibleStateImageBehavior = false;
            this.lvListeNombre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code famille";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Désignation";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre autorisé";
            this.columnHeader3.Width = 152;
            // 
            // frm_consultation_medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1349, 619);
            this.Controls.Add(this.lvListeNombre);
            this.Name = "frm_consultation_medicament";
            this.Text = "frm_consultation_medicament";
            this.Load += new System.EventHandler(this.frm_consultation_medicament_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListeNombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
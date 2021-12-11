
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
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvListeNombre
            // 
            this.lvListeNombre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvListeNombre.FullRowSelect = true;
            this.lvListeNombre.HideSelection = false;
            this.lvListeNombre.Location = new System.Drawing.Point(126, 131);
            this.lvListeNombre.Name = "lvListeNombre";
            this.lvListeNombre.Size = new System.Drawing.Size(671, 443);
            this.lvListeNombre.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvListeNombre.TabIndex = 0;
            this.lvListeNombre.UseCompatibleStateImageBehavior = false;
            this.lvListeNombre.View = System.Windows.Forms.View.Details;
            this.lvListeNombre.SelectedIndexChanged += new System.EventHandler(this.lvListeNombre_SelectedIndexChanged);
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
            // lvMedicaments
            // 
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(875, 131);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Size = new System.Drawing.Size(903, 443);
            this.lvMedicaments.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMedicaments.TabIndex = 1;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            this.lvMedicaments.SelectedIndexChanged += new System.EventHandler(this.lvMedicaments_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Depot Legal";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Composition";
            this.columnHeader6.Width = 155;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Effets";
            this.columnHeader7.Width = 228;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ContreIndication";
            this.columnHeader8.Width = 299;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(822, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des médicaments par famille";
            // 
            // frm_consultation_medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1924, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.lvListeNombre);
            this.Name = "frm_consultation_medicament";
            this.Text = "frm_consultation_medicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_consultation_medicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListeNombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}
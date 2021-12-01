namespace APSwissVisite
{
    partial class Encoure
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
            this.lvEncourec = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvEncourec
            // 
            this.lvEncourec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEncourec.FullRowSelect = true;
            this.lvEncourec.HideSelection = false;
            this.lvEncourec.Location = new System.Drawing.Point(29, 23);
            this.lvEncourec.Name = "lvEncourec";
            this.lvEncourec.Size = new System.Drawing.Size(503, 251);
            this.lvEncourec.TabIndex = 0;
            this.lvEncourec.UseCompatibleStateImageBehavior = false;
            this.lvEncourec.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépot legal";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nom commercial";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "libelle famille";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 215;
            // 
            // Encoure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvEncourec);
            this.Name = "Encoure";
            this.Text = "Encoure";
            this.Load += new System.EventHandler(this.Encoure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEncourec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
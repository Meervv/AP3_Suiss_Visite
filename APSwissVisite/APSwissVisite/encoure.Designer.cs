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
            this.gbWorkflow = new System.Windows.Forms.GroupBox();
            this.lvWorkflow = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRetour = new System.Windows.Forms.Button();
            this.gbWorkflow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEncourec
            // 
            this.lvEncourec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEncourec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEncourec.FullRowSelect = true;
            this.lvEncourec.HideSelection = false;
            this.lvEncourec.Location = new System.Drawing.Point(29, 23);
            this.lvEncourec.Name = "lvEncourec";
            this.lvEncourec.Size = new System.Drawing.Size(670, 251);
            this.lvEncourec.TabIndex = 0;
            this.lvEncourec.UseCompatibleStateImageBehavior = false;
            this.lvEncourec.View = System.Windows.Forms.View.Details;
            this.lvEncourec.SelectedIndexChanged += new System.EventHandler(this.lvEncourec_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépot legal";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nom commercial";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 191;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "libelle famille";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 299;
            // 
            // gbWorkflow
            // 
            this.gbWorkflow.BackColor = System.Drawing.Color.LightCoral;
            this.gbWorkflow.Controls.Add(this.lvWorkflow);
            this.gbWorkflow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkflow.Location = new System.Drawing.Point(29, 280);
            this.gbWorkflow.Name = "gbWorkflow";
            this.gbWorkflow.Size = new System.Drawing.Size(513, 251);
            this.gbWorkflow.TabIndex = 1;
            this.gbWorkflow.TabStop = false;
            this.gbWorkflow.Text = "Workflow médicament";
            this.gbWorkflow.Visible = false;
            this.gbWorkflow.Enter += new System.EventHandler(this.gbWorkflow_Enter);
            // 
            // lvWorkflow
            // 
            this.lvWorkflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvWorkflow.FullRowSelect = true;
            this.lvWorkflow.HideSelection = false;
            this.lvWorkflow.Location = new System.Drawing.Point(15, 20);
            this.lvWorkflow.Name = "lvWorkflow";
            this.lvWorkflow.Size = new System.Drawing.Size(472, 210);
            this.lvWorkflow.TabIndex = 0;
            this.lvWorkflow.UseCompatibleStateImageBehavior = false;
            this.lvWorkflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date décision";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Num étape";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id décision";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 151;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(557, 300);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(127, 37);
            this.btRetour.TabIndex = 2;
            this.btRetour.Text = "retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // Encoure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(893, 565);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.gbWorkflow);
            this.Controls.Add(this.lvEncourec);
            this.Name = "Encoure";
            this.Text = "Encoure";
            this.Load += new System.EventHandler(this.Encoure_Load);
            this.gbWorkflow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEncourec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbWorkflow;
        private System.Windows.Forms.ListView lvWorkflow;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btRetour;
    }
}
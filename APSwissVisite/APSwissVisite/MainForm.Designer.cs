
namespace APSwissVisite
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeÉtapesNorméesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationMédicamentEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesWorkflowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saisieDécisionÉtapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeÉtapesNorméesToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.workflowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeÉtapesNorméesToolStripMenuItem
            // 
            this.listeÉtapesNorméesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem});
            this.listeÉtapesNorméesToolStripMenuItem.Name = "listeÉtapesNorméesToolStripMenuItem";
            this.listeÉtapesNorméesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.listeÉtapesNorméesToolStripMenuItem.Text = "Etapes normées";
            this.listeÉtapesNorméesToolStripMenuItem.Click += new System.EventHandler(this.listeÉtapesNorméesToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.saisieDécisionÉtapeToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.ajoutToolStripMenuItem.Text = "Ajout ";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // workflowToolStripMenuItem
            // 
            this.workflowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationMédicamentEnCoursToolStripMenuItem,
            this.consultationDesWorkflowsToolStripMenuItem});
            this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
            this.workflowToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.workflowToolStripMenuItem.Text = "Workflow";
            // 
            // consultationMédicamentEnCoursToolStripMenuItem
            // 
            this.consultationMédicamentEnCoursToolStripMenuItem.Name = "consultationMédicamentEnCoursToolStripMenuItem";
            this.consultationMédicamentEnCoursToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.consultationMédicamentEnCoursToolStripMenuItem.Text = "Consultation médicament en cours";
            this.consultationMédicamentEnCoursToolStripMenuItem.Click += new System.EventHandler(this.consultationMédicamentEnCoursToolStripMenuItem_Click);
            // 
            // consultationDesWorkflowsToolStripMenuItem
            // 
            this.consultationDesWorkflowsToolStripMenuItem.Name = "consultationDesWorkflowsToolStripMenuItem";
            this.consultationDesWorkflowsToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.consultationDesWorkflowsToolStripMenuItem.Text = "Consultation des workflows";
            this.consultationDesWorkflowsToolStripMenuItem.Click += new System.EventHandler(this.consultationDesWorkflowsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saisieDécisionÉtapeToolStripMenuItem
            // 
            this.saisieDécisionÉtapeToolStripMenuItem.Name = "saisieDécisionÉtapeToolStripMenuItem";
            this.saisieDécisionÉtapeToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saisieDécisionÉtapeToolStripMenuItem.Text = "Saisie décision étape";
            this.saisieDécisionÉtapeToolStripMenuItem.Click += new System.EventHandler(this.saisieDécisionÉtapeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeÉtapesNorméesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workflowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationMédicamentEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesWorkflowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDécisionÉtapeToolStripMenuItem;
    }
}


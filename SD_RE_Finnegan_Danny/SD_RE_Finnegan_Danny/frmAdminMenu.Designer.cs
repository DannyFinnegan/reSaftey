
namespace SD_RE_Finnegan_Danny
{
    partial class frmAdminMenu
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
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.btnYearlyRevnueAnalyisi = new System.Windows.Forms.Button();
            this.btnYearlyRevnueAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.Location = new System.Drawing.Point(100, 37);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(640, 55);
            this.lblAdminMenu.TabIndex = 0;
            this.lblAdminMenu.Text = "Welcome to the Admin Menu";
            // 
            // btnYearlyRevnueAnalyisi
            // 
            this.btnYearlyRevnueAnalyisi.Location = new System.Drawing.Point(169, 357);
            this.btnYearlyRevnueAnalyisi.Name = "btnYearlyRevnueAnalyisi";
            this.btnYearlyRevnueAnalyisi.Size = new System.Drawing.Size(141, 23);
            this.btnYearlyRevnueAnalyisi.TabIndex = 1;
            this.btnYearlyRevnueAnalyisi.Text = "Yearly Revenue Analysis";
            this.btnYearlyRevnueAnalyisi.UseVisualStyleBackColor = true;
            this.btnYearlyRevnueAnalyisi.Click += new System.EventHandler(this.btnYearlyRevnueAnalyisi_Click);
            // 
            // btnYearlyRevnueAnalysis
            // 
            this.btnYearlyRevnueAnalysis.Location = new System.Drawing.Point(458, 357);
            this.btnYearlyRevnueAnalysis.Name = "btnYearlyRevnueAnalysis";
            this.btnYearlyRevnueAnalysis.Size = new System.Drawing.Size(141, 23);
            this.btnYearlyRevnueAnalysis.TabIndex = 2;
            this.btnYearlyRevnueAnalysis.Text = "Yearly Part Analysis";
            this.btnYearlyRevnueAnalysis.UseVisualStyleBackColor = true;
            this.btnYearlyRevnueAnalysis.Click += new System.EventHandler(this.btnYearlyRevnueAnalysis_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYearlyRevnueAnalysis);
            this.Controls.Add(this.btnYearlyRevnueAnalyisi);
            this.Controls.Add(this.lblAdminMenu);
            this.Name = "frmAdminMenu";
            this.Text = "frmAdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Button btnYearlyRevnueAnalyisi;
        private System.Windows.Forms.Button btnYearlyRevnueAnalysis;
    }
}
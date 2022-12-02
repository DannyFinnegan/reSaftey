
namespace SD_RE_Finnegan_Danny
{
    partial class frmMain_Menu
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
            this.btnPartMenu = new System.Windows.Forms.Button();
            this.btnRepairMenu = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To DF Repair Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPartMenu
            // 
            this.btnPartMenu.Location = new System.Drawing.Point(118, 312);
            this.btnPartMenu.Name = "btnPartMenu";
            this.btnPartMenu.Size = new System.Drawing.Size(85, 23);
            this.btnPartMenu.TabIndex = 1;
            this.btnPartMenu.Text = "Part Menu";
            this.btnPartMenu.UseVisualStyleBackColor = true;
            this.btnPartMenu.Click += new System.EventHandler(this.btnPartMenu_Click);
            // 
            // btnRepairMenu
            // 
            this.btnRepairMenu.Location = new System.Drawing.Point(333, 312);
            this.btnRepairMenu.Name = "btnRepairMenu";
            this.btnRepairMenu.Size = new System.Drawing.Size(85, 23);
            this.btnRepairMenu.TabIndex = 2;
            this.btnRepairMenu.Text = "Repair Menu";
            this.btnRepairMenu.UseVisualStyleBackColor = true;
            this.btnRepairMenu.Click += new System.EventHandler(this.btnRepairMenu_Click);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(575, 312);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(85, 23);
            this.btnAdminMenu.TabIndex = 3;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // frmMain_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnRepairMenu);
            this.Controls.Add(this.btnPartMenu);
            this.Controls.Add(this.label1);
            this.Name = "frmMain_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartMenu;
        private System.Windows.Forms.Button btnRepairMenu;
        private System.Windows.Forms.Button btnAdminMenu;
    }
}
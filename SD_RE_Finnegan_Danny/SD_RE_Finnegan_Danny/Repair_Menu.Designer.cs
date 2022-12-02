
namespace SD_RE_Finnegan_Danny
{
    partial class frmRepair_Menu
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
            this.btnLogRepair = new System.Windows.Forms.Button();
            this.btnEstimateRepair = new System.Windows.Forms.Button();
            this.btnConfirmRepair = new System.Windows.Forms.Button();
            this.btnCompleteRepair = new System.Windows.Forms.Button();
            this.btnReturnRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the repair menu";
            // 
            // btnLogRepair
            // 
            this.btnLogRepair.Location = new System.Drawing.Point(118, 341);
            this.btnLogRepair.Name = "btnLogRepair";
            this.btnLogRepair.Size = new System.Drawing.Size(101, 23);
            this.btnLogRepair.TabIndex = 1;
            this.btnLogRepair.Text = "Log Repair";
            this.btnLogRepair.UseVisualStyleBackColor = true;
            this.btnLogRepair.Click += new System.EventHandler(this.btnLogRepair_Click);
            // 
            // btnEstimateRepair
            // 
            this.btnEstimateRepair.Location = new System.Drawing.Point(225, 341);
            this.btnEstimateRepair.Name = "btnEstimateRepair";
            this.btnEstimateRepair.Size = new System.Drawing.Size(101, 23);
            this.btnEstimateRepair.TabIndex = 2;
            this.btnEstimateRepair.Text = "Estimate Repair";
            this.btnEstimateRepair.UseVisualStyleBackColor = true;
            this.btnEstimateRepair.Click += new System.EventHandler(this.btnEstimateRepair_Click);
            // 
            // btnConfirmRepair
            // 
            this.btnConfirmRepair.Location = new System.Drawing.Point(332, 341);
            this.btnConfirmRepair.Name = "btnConfirmRepair";
            this.btnConfirmRepair.Size = new System.Drawing.Size(101, 23);
            this.btnConfirmRepair.TabIndex = 3;
            this.btnConfirmRepair.Text = "Confirm Repair";
            this.btnConfirmRepair.UseVisualStyleBackColor = true;
            this.btnConfirmRepair.Click += new System.EventHandler(this.btnConfirmRepair_Click);
            // 
            // btnCompleteRepair
            // 
            this.btnCompleteRepair.Location = new System.Drawing.Point(439, 341);
            this.btnCompleteRepair.Name = "btnCompleteRepair";
            this.btnCompleteRepair.Size = new System.Drawing.Size(101, 23);
            this.btnCompleteRepair.TabIndex = 4;
            this.btnCompleteRepair.Text = "Complete Repair";
            this.btnCompleteRepair.UseVisualStyleBackColor = true;
            this.btnCompleteRepair.Click += new System.EventHandler(this.btnCompleteRepair_Click);
            // 
            // btnReturnRepair
            // 
            this.btnReturnRepair.Location = new System.Drawing.Point(546, 341);
            this.btnReturnRepair.Name = "btnReturnRepair";
            this.btnReturnRepair.Size = new System.Drawing.Size(101, 23);
            this.btnReturnRepair.TabIndex = 5;
            this.btnReturnRepair.Text = "Return Repair";
            this.btnReturnRepair.UseVisualStyleBackColor = true;
            this.btnReturnRepair.Click += new System.EventHandler(this.btnReturnRepair_Click);
            // 
            // frmRepair_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnRepair);
            this.Controls.Add(this.btnCompleteRepair);
            this.Controls.Add(this.btnConfirmRepair);
            this.Controls.Add(this.btnEstimateRepair);
            this.Controls.Add(this.btnLogRepair);
            this.Controls.Add(this.label1);
            this.Name = "frmRepair_Menu";
            this.Text = "Repair_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogRepair;
        private System.Windows.Forms.Button btnEstimateRepair;
        private System.Windows.Forms.Button btnConfirmRepair;
        private System.Windows.Forms.Button btnCompleteRepair;
        private System.Windows.Forms.Button btnReturnRepair;
    }
}
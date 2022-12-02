
namespace SD_RE_Finnegan_Danny
{
    partial class frmReturnRepai
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
            this.lblReturnRepair = new System.Windows.Forms.Label();
            this.txtReturnedRepair = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReturnRepair
            // 
            this.lblReturnRepair.AutoSize = true;
            this.lblReturnRepair.Location = new System.Drawing.Point(241, 145);
            this.lblReturnRepair.Name = "lblReturnRepair";
            this.lblReturnRepair.Size = new System.Drawing.Size(142, 13);
            this.lblReturnRepair.TabIndex = 0;
            this.lblReturnRepair.Text = "Has the repair been returned";
            this.lblReturnRepair.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtReturnedRepair
            // 
            this.txtReturnedRepair.Location = new System.Drawing.Point(389, 142);
            this.txtReturnedRepair.Name = "txtReturnedRepair";
            this.txtReturnedRepair.Size = new System.Drawing.Size(100, 20);
            this.txtReturnedRepair.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(399, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmReturnRepai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReturnedRepair);
            this.Controls.Add(this.lblReturnRepair);
            this.Name = "frmReturnRepai";
            this.Text = "Return Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnRepair;
        private System.Windows.Forms.TextBox txtReturnedRepair;
        private System.Windows.Forms.Button btnSubmit;
    }
}
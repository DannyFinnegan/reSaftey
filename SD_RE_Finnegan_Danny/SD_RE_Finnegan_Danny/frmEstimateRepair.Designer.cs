
namespace SD_RE_Finnegan_Danny
{
    partial class frmEstimateRepair
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
            this.lblRepairID = new System.Windows.Forms.Label();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRepairCost = new System.Windows.Forms.Label();
            this.lblRepairDate = new System.Windows.Forms.Label();
            this.txtRepairDate = new System.Windows.Forms.TextBox();
            this.txtRepairCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Location = new System.Drawing.Point(310, 145);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(52, 13);
            this.lblRepairID.TabIndex = 0;
            this.lblRepairID.Text = "Repair ID";
            // 
            // txtRepairID
            // 
            this.txtRepairID.Location = new System.Drawing.Point(368, 142);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(100, 20);
            this.txtRepairID.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(380, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRepairCost
            // 
            this.lblRepairCost.AutoSize = true;
            this.lblRepairCost.Location = new System.Drawing.Point(300, 171);
            this.lblRepairCost.Name = "lblRepairCost";
            this.lblRepairCost.Size = new System.Drawing.Size(62, 13);
            this.lblRepairCost.TabIndex = 3;
            this.lblRepairCost.Text = "Repair Cost";
            // 
            // lblRepairDate
            // 
            this.lblRepairDate.AutoSize = true;
            this.lblRepairDate.Location = new System.Drawing.Point(259, 197);
            this.lblRepairDate.Name = "lblRepairDate";
            this.lblRepairDate.Size = new System.Drawing.Size(103, 13);
            this.lblRepairDate.TabIndex = 4;
            this.lblRepairDate.Text = "Logged Repair Date";
            // 
            // txtRepairDate
            // 
            this.txtRepairDate.Location = new System.Drawing.Point(368, 194);
            this.txtRepairDate.Name = "txtRepairDate";
            this.txtRepairDate.Size = new System.Drawing.Size(100, 20);
            this.txtRepairDate.TabIndex = 5;
            // 
            // txtRepairCost
            // 
            this.txtRepairCost.Location = new System.Drawing.Point(368, 168);
            this.txtRepairCost.Name = "txtRepairCost";
            this.txtRepairCost.Size = new System.Drawing.Size(100, 20);
            this.txtRepairCost.TabIndex = 6;
            // 
            // frmEstimateRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepairCost);
            this.Controls.Add(this.txtRepairDate);
            this.Controls.Add(this.lblRepairDate);
            this.Controls.Add(this.lblRepairCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Name = "frmEstimateRepair";
            this.Text = "frmEstimateRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRepairCost;
        private System.Windows.Forms.Label lblRepairDate;
        private System.Windows.Forms.TextBox txtRepairDate;
        private System.Windows.Forms.TextBox txtRepairCost;
    }
}
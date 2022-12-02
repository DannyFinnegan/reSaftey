
namespace SD_RE_Finnegan_Danny
{
    partial class frmLogRepair
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
            this.lblRepairStatus = new System.Windows.Forms.Label();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.lblRepairDate = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtRepairStatus = new System.Windows.Forms.TextBox();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.txtRepairDate = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRepairStatus
            // 
            this.lblRepairStatus.AutoSize = true;
            this.lblRepairStatus.Location = new System.Drawing.Point(273, 109);
            this.lblRepairStatus.Name = "lblRepairStatus";
            this.lblRepairStatus.Size = new System.Drawing.Size(71, 13);
            this.lblRepairStatus.TabIndex = 0;
            this.lblRepairStatus.Text = "Repair Status";
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Location = new System.Drawing.Point(292, 135);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(52, 13);
            this.lblRepairID.TabIndex = 1;
            this.lblRepairID.Text = "Repair ID";
            // 
            // lblRepairDate
            // 
            this.lblRepairDate.AutoSize = true;
            this.lblRepairDate.Location = new System.Drawing.Point(280, 161);
            this.lblRepairDate.Name = "lblRepairDate";
            this.lblRepairDate.Size = new System.Drawing.Size(64, 13);
            this.lblRepairDate.TabIndex = 2;
            this.lblRepairDate.Text = "Repair Date";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(265, 187);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(79, 13);
            this.lblCustomerEmail.TabIndex = 3;
            this.lblCustomerEmail.Text = "Customer Email";
            // 
            // txtRepairStatus
            // 
            this.txtRepairStatus.Location = new System.Drawing.Point(350, 106);
            this.txtRepairStatus.Name = "txtRepairStatus";
            this.txtRepairStatus.Size = new System.Drawing.Size(100, 20);
            this.txtRepairStatus.TabIndex = 4;
            // 
            // txtRepairID
            // 
            this.txtRepairID.Location = new System.Drawing.Point(350, 132);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(100, 20);
            this.txtRepairID.TabIndex = 5;
            // 
            // txtRepairDate
            // 
            this.txtRepairDate.Location = new System.Drawing.Point(350, 158);
            this.txtRepairDate.Name = "txtRepairDate";
            this.txtRepairDate.Size = new System.Drawing.Size(100, 20);
            this.txtRepairDate.TabIndex = 6;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(350, 184);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(363, 210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmLogRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtRepairDate);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.txtRepairStatus);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblRepairDate);
            this.Controls.Add(this.lblRepairID);
            this.Controls.Add(this.lblRepairStatus);
            this.Name = "frmLogRepair";
            this.Text = "frmLogRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepairStatus;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.Label lblRepairDate;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtRepairStatus;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.TextBox txtRepairDate;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button btnSubmit;
    }
}
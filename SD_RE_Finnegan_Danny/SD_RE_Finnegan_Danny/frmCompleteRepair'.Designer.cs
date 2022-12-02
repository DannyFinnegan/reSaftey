
namespace SD_RE_Finnegan_Danny
{
    partial class frmCompleteRepair_
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
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRepairCompleted = new System.Windows.Forms.Label();
            this.txtRepairComplete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(285, 173);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(79, 13);
            this.lblCustomerEmail.TabIndex = 0;
            this.lblCustomerEmail.Text = "Customer Email";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(370, 170);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(380, 222);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRepairCompleted
            // 
            this.lblRepairCompleted.AutoSize = true;
            this.lblRepairCompleted.Location = new System.Drawing.Point(255, 199);
            this.lblRepairCompleted.Name = "lblRepairCompleted";
            this.lblRepairCompleted.Size = new System.Drawing.Size(109, 13);
            this.lblRepairCompleted.TabIndex = 3;
            this.lblRepairCompleted.Text = "Is the repair Complete";
            // 
            // txtRepairComplete
            // 
            this.txtRepairComplete.Location = new System.Drawing.Point(370, 196);
            this.txtRepairComplete.Name = "txtRepairComplete";
            this.txtRepairComplete.Size = new System.Drawing.Size(100, 20);
            this.txtRepairComplete.TabIndex = 4;
            // 
            // frmCompleteRepair_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepairComplete);
            this.Controls.Add(this.lblRepairCompleted);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.lblCustomerEmail);
            this.Name = "frmCompleteRepair_";
            this.Text = "CompleteRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRepairCompleted;
        private System.Windows.Forms.TextBox txtRepairComplete;
    }
}
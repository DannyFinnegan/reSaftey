
namespace SD_RE_Finnegan_Danny
{
    partial class frmDelete_Part
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
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.PartNum = new System.Windows.Forms.Label();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(354, 123);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 0;
            this.btnDeletePart.Text = "Delete Part";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // PartNum
            // 
            this.PartNum.BackColor = System.Drawing.SystemColors.Window;
            this.PartNum.Location = new System.Drawing.Point(259, 103);
            this.PartNum.Name = "PartNum";
            this.PartNum.Size = new System.Drawing.Size(118, 13);
            this.PartNum.TabIndex = 2;
            this.PartNum.Text = "Part ID to be deleted:";
            this.PartNum.Click += new System.EventHandler(this.PartNum_Click);
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(383, 100);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(121, 20);
            this.txtPartId.TabIndex = 15;
            // 
            // frmDelete_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPartId);
            this.Controls.Add(this.PartNum);
            this.Controls.Add(this.btnDeletePart);
            this.Name = "frmDelete_Part";
            this.Text = "Delete Part";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Label PartNum;
        private System.Windows.Forms.TextBox txtPartId;
    }
}
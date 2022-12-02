
namespace SD_RE_Finnegan_Danny
{
    partial class frmAddPart
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
            this.lblPartType = new System.Windows.Forms.Label();
            this.cboPartType = new System.Windows.Forms.ComboBox();
            this.txtPartDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPartDescription = new System.Windows.Forms.Label();
            this.txtPartCost = new System.Windows.Forms.TextBox();
            this.txtPartStock = new System.Windows.Forms.TextBox();
            this.lblPartCost = new System.Windows.Forms.Label();
            this.lblPartStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPartType
            // 
            this.lblPartType.AutoSize = true;
            this.lblPartType.Location = new System.Drawing.Point(261, 92);
            this.lblPartType.Name = "lblPartType";
            this.lblPartType.Size = new System.Drawing.Size(53, 13);
            this.lblPartType.TabIndex = 0;
            this.lblPartType.Text = "Part Type";
            // 
            // cboPartType
            // 
            this.cboPartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartType.FormattingEnabled = true;
            this.cboPartType.Location = new System.Drawing.Point(320, 89);
            this.cboPartType.Name = "cboPartType";
            this.cboPartType.Size = new System.Drawing.Size(121, 21);
            this.cboPartType.TabIndex = 1;
            // 
            // txtPartDescription
            // 
            this.txtPartDescription.Location = new System.Drawing.Point(320, 116);
            this.txtPartDescription.Name = "txtPartDescription";
            this.txtPartDescription.Size = new System.Drawing.Size(121, 20);
            this.txtPartDescription.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPartDescription
            // 
            this.lblPartDescription.AutoSize = true;
            this.lblPartDescription.Location = new System.Drawing.Point(232, 119);
            this.lblPartDescription.Name = "lblPartDescription";
            this.lblPartDescription.Size = new System.Drawing.Size(82, 13);
            this.lblPartDescription.TabIndex = 4;
            this.lblPartDescription.Text = "Part Description";
            // 
            // txtPartCost
            // 
            this.txtPartCost.Location = new System.Drawing.Point(320, 142);
            this.txtPartCost.Name = "txtPartCost";
            this.txtPartCost.Size = new System.Drawing.Size(121, 20);
            this.txtPartCost.TabIndex = 5;
            // 
            // txtPartStock
            // 
            this.txtPartStock.Location = new System.Drawing.Point(320, 168);
            this.txtPartStock.Name = "txtPartStock";
            this.txtPartStock.Size = new System.Drawing.Size(121, 20);
            this.txtPartStock.TabIndex = 6;
            // 
            // lblPartCost
            // 
            this.lblPartCost.AutoSize = true;
            this.lblPartCost.Location = new System.Drawing.Point(264, 145);
            this.lblPartCost.Name = "lblPartCost";
            this.lblPartCost.Size = new System.Drawing.Size(50, 13);
            this.lblPartCost.TabIndex = 7;
            this.lblPartCost.Text = "Part Cost";
            // 
            // lblPartStock
            // 
            this.lblPartStock.AutoSize = true;
            this.lblPartStock.Location = new System.Drawing.Point(257, 171);
            this.lblPartStock.Name = "lblPartStock";
            this.lblPartStock.Size = new System.Drawing.Size(57, 13);
            this.lblPartStock.TabIndex = 8;
            this.lblPartStock.Text = "Part Stock";
            // 
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPartStock);
            this.Controls.Add(this.lblPartCost);
            this.Controls.Add(this.txtPartStock);
            this.Controls.Add(this.txtPartCost);
            this.Controls.Add(this.lblPartDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPartDescription);
            this.Controls.Add(this.cboPartType);
            this.Controls.Add(this.lblPartType);
            this.Name = "frmAddPart";
            this.Text = "frmAddPart";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartType;
        private System.Windows.Forms.ComboBox cboPartType;
        private System.Windows.Forms.TextBox txtPartDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPartDescription;
        private System.Windows.Forms.TextBox txtPartCost;
        private System.Windows.Forms.TextBox txtPartStock;
        private System.Windows.Forms.Label lblPartCost;
        private System.Windows.Forms.Label lblPartStock;
    }
}

namespace SD_RE_Finnegan_Danny
{
    partial class frmYearlyRevnueAnalysis
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
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.cboYearSelect = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Location = new System.Drawing.Point(304, 147);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(71, 13);
            this.lblSelectYear.TabIndex = 0;
            this.lblSelectYear.Text = "Select a Year";
            // 
            // cboYearSelect
            // 
            this.cboYearSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearSelect.FormattingEnabled = true;
            this.cboYearSelect.Location = new System.Drawing.Point(381, 144);
            this.cboYearSelect.Name = "cboYearSelect";
            this.cboYearSelect.Size = new System.Drawing.Size(121, 21);
            this.cboYearSelect.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(400, 171);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmYearlyRevnueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboYearSelect);
            this.Controls.Add(this.lblSelectYear);
            this.Name = "frmYearlyRevnueAnalysis";
            this.Text = "frmYearlyRevnueAnalysis";
            this.Load += new System.EventHandler(this.frmYearlyRevnueAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.ComboBox cboYearSelect;
        private System.Windows.Forms.Button btnSubmit;
    }
}
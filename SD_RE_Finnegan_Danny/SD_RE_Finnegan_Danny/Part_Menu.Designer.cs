
namespace SD_RE_Finnegan_Danny
{
    partial class frmPart_Menu
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
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.btnDiscontinuePart = new System.Windows.Forms.Button();
            this.btnQueryPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Parts Menu";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(134, 335);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(102, 23);
            this.btnAddPart.TabIndex = 1;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.Location = new System.Drawing.Point(272, 335);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(102, 23);
            this.btnUpdatePart.TabIndex = 2;
            this.btnUpdatePart.Text = "Update Part";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btnDiscontinuePart
            // 
            this.btnDiscontinuePart.Location = new System.Drawing.Point(411, 335);
            this.btnDiscontinuePart.Name = "btnDiscontinuePart";
            this.btnDiscontinuePart.Size = new System.Drawing.Size(102, 23);
            this.btnDiscontinuePart.TabIndex = 3;
            this.btnDiscontinuePart.Text = "Discontinue Part";
            this.btnDiscontinuePart.UseVisualStyleBackColor = true;
            this.btnDiscontinuePart.Click += new System.EventHandler(this.btnDiscontinuePart_Click);
            // 
            // btnQueryPart
            // 
            this.btnQueryPart.Location = new System.Drawing.Point(550, 335);
            this.btnQueryPart.Name = "btnQueryPart";
            this.btnQueryPart.Size = new System.Drawing.Size(102, 23);
            this.btnQueryPart.TabIndex = 4;
            this.btnQueryPart.Text = "Query Part";
            this.btnQueryPart.UseVisualStyleBackColor = true;
            this.btnQueryPart.Click += new System.EventHandler(this.btnQueryPart_Click);
            // 
            // frmPart_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQueryPart);
            this.Controls.Add(this.btnDiscontinuePart);
            this.Controls.Add(this.btnUpdatePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.label1);
            this.Name = "frmPart_Menu";
            this.Text = "Part_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.Button btnDiscontinuePart;
        private System.Windows.Forms.Button btnQueryPart;
    }
}
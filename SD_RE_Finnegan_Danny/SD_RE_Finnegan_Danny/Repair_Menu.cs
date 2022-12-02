using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_RE_Finnegan_Danny
{
    public partial class frmRepair_Menu : Form
    {
        public frmRepair_Menu(frmMain_Menu frmMain_Menu)
        {
            InitializeComponent();
        }

        private void btnLogRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogRepair nextForm = new frmLogRepair(this);
            nextForm.Show();
        }

        private void btnEstimateRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstimateRepair nextForm = new frmEstimateRepair(this);
            nextForm.Show();
        }

        private void btnConfirmRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfirmRepair nextForm = new frmConfirmRepair(this);
            nextForm.Show();
        }

        private void btnCompleteRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompleteRepair_ nextForm = new frmCompleteRepair_(this);
            nextForm.Show();
        }

        private void btnReturnRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnRepai nextForm = new frmReturnRepai(this);
            nextForm.Show();
        }
    }
}

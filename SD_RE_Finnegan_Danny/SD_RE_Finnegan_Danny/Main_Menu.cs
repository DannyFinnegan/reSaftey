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
    public partial class frmMain_Menu : Form
    {
        public frmMain_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPartMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPart_Menu nextForm = new frmPart_Menu(this);
            nextForm.Show();

        }

        private void btnRepairMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRepair_Menu nextForm = new frmRepair_Menu(this);
            nextForm.Show();
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminMenu nextForm = new frmAdminMenu(this);
            nextForm.Show();
        }
    }
}

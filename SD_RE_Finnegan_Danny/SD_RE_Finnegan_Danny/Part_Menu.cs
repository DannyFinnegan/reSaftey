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
    public partial class frmPart_Menu : Form
    {
        public frmPart_Menu(frmMain_Menu frmMain_Menu)
        {
            InitializeComponent();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPart nextForm = new frmAddPart(this);
            nextForm.Show();
        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdate_Part nextForm = new frmUpdate_Part(this);
            nextForm.Show();
        }

        private void btnDiscontinuePart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDelete_Part nextForm = new frmDelete_Part(this);
            nextForm.Show();
        }

        private void btnQueryPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryPart nextForm = new frmQueryPart(this);
            nextForm.Show();
        }
    }
}

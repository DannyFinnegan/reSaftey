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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu(frmMain_Menu frmMain_Menu)
        {
            InitializeComponent();
        }

        private void btnYearlyRevnueAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevnueAnalysis nextForm = new frmYearlyRevnueAnalysis(this);
            nextForm.Show();
        }

        private void btnYearlyRevnueAnalyisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyPartAnalysis nextForm = new frmYearlyPartAnalysis(this);
            nextForm.Show();
        }
    }
}

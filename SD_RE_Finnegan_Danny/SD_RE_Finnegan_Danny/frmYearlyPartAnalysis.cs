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
    public partial class frmYearlyPartAnalysis : Form
    {
        public frmYearlyPartAnalysis(frmAdminMenu frmAdminMenu)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboYearSelect.SelectedIndex == -1)
            {
                MessageBox.Show("A Year Must Be Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cboYearSelect.SelectedIndex == 0)
            {
                MessageBox.Show("Total Parts Bought: 2000\nTotal Parts Used: 1500\nRemainder: 500", "2017", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cboYearSelect.SelectedIndex == 1)
            {
                MessageBox.Show("Total Parts Bought: 3000\nTotal Parts Used: 2000\nRemainder: 1500", "2018", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cboYearSelect.SelectedIndex == 2)
            {
                MessageBox.Show("Total Parts Bought: 2000\nTotal Parts Used: 2500\nRemainder: 1000", "2019", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cboYearSelect.SelectedIndex == 3)
            {
                MessageBox.Show("Total Parts Bought: 3000\nTotal Parts Used: 2500\nRemainder: 1500", "2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cboYearSelect.SelectedIndex == 4)
            {
                MessageBox.Show("Total Parts Bought: 2000\nTotal Parts Used: 3000\nRemainder: 500", "2021", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmYearlyPartAnalysis_Load(object sender, EventArgs e)
        {
            cboYearSelect.Items.Add("2017");
            cboYearSelect.Items.Add("2018");
            cboYearSelect.Items.Add("2019");
            cboYearSelect.Items.Add("2020");
            cboYearSelect.Items.Add("2021");
        }
    }
}

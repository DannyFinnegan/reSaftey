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
    public partial class frmReturnRepai : Form
    {
        public frmReturnRepai(frmRepair_Menu frmRepair_Menu)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String RepairCompleteAsString = txtReturnedRepair.Text.ToLower();

            if (RepairCompleteAsString != "")
            {
                if (RepairCompleteAsString == "yes")
                {
                    MessageBox.Show("The repair has been marked complete and the customer has been notified", "Repair Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnedRepair.ResetText();
                }
                if (RepairCompleteAsString == "no")
                {
                    MessageBox.Show("The repair cannot be marked complte until it has been completed", "Repair Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnedRepair.ResetText();
                }
                else if(RepairCompleteAsString == "")
                {
                    MessageBox.Show("A value must be entered to repair completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

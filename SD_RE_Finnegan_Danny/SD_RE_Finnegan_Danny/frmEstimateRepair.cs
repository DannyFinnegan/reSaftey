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
    public partial class frmEstimateRepair : Form
    {
        public frmEstimateRepair(frmRepair_Menu frmRepair_Menu)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String RepairIDAsString = txtRepairID.Text;
            String RepairDateAsString = txtRepairDate.Text;
            String RepairCostAsString = txtRepairCost.Text;
            bool CanConvertID = int.TryParse(RepairIDAsString, out _);
            bool CanCOnvertCost = int.TryParse(RepairCostAsString, out _);

            if(RepairIDAsString != "" && CanConvertID == true && RepairDateAsString != "" && RepairCostAsString != "" && CanCOnvertCost == true)
            {
                MessageBox.Show("The Repair has been marked as estimated and a email has been sent to the customer", "Action Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRepairCost.ResetText();
                txtRepairDate.ResetText();
                txtRepairID.ResetText();
            }
            else if(RepairIDAsString == "")
            {
                MessageBox.Show("Repair ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
            }

            else if (RepairCostAsString == "")
            {
                MessageBox.Show("Repair cost cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairCost.Focus();
            }

            else if (CanCOnvertCost == false)
            {
                MessageBox.Show("Repair cost must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairCost.Focus();
                txtRepairCost.ResetText();
            }

            else if(CanConvertID == false)
            {
                MessageBox.Show("Repair ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                txtRepairID.ResetText();
            }

            else if (RepairDateAsString == "")
            {
                MessageBox.Show("Repair date cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairDate.Focus();
            }
        }

    }
}

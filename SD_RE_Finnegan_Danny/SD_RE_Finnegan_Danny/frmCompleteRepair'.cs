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
    public partial class frmCompleteRepair_ : Form
    {
        public frmCompleteRepair_(frmRepair_Menu frmRepair_Menu)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String CustEmailAsString = txtCustomerEmail.Text;
            String RepairCompleteAsString = txtRepairComplete.Text.ToLower();
            bool ContainsAt = CustEmailAsString.Contains("@gmail.com");
           

            if (CustEmailAsString != "" && RepairCompleteAsString != "" && ContainsAt == true)
            {
                if (RepairCompleteAsString == "yes")
                {
                    MessageBox.Show("The repair has been marked complete and the customer has been notified", "Repair Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerEmail.ResetText();
                    txtRepairComplete.ResetText();
                }
                if (RepairCompleteAsString == "no")
                {
                    MessageBox.Show("The repair cannot be marked complte until it has been completed", "Repair Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerEmail.ResetText();
                    txtRepairComplete.ResetText();
                }
            }
            else if (CustEmailAsString == "")
            {
                MessageBox.Show("Customer Email cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.ResetText();
            }

            else if (ContainsAt == false)
            {
                MessageBox.Show("Customer Email must contain an @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
            }
            
            else if (RepairCompleteAsString == "")
            {
                MessageBox.Show("Repair Complete must be marked yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairComplete.Focus();
            }
            else if(RepairCompleteAsString != "yes" || RepairCompleteAsString != "no")
            {
                MessageBox.Show("Repair Complete must be marked yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairComplete.Focus();
            }
        }
    }
}

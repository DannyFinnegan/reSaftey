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
    public partial class frmLogRepair : Form
    {
        public frmLogRepair(frmRepair_Menu frmRepair_Menu)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String RepairStatusAsString = txtRepairStatus.Text.ToUpper();
            String RepairIDAsString = txtRepairID.Text;
            String RepairDateAsString = txtRepairDate.Text;
            String CustEmailAsString = txtCustomerEmail.Text;
            bool CanConvertID = int.TryParse(RepairIDAsString, out _);
            bool ContainsAt = CustEmailAsString.Contains("@gmail.com");

            if (RepairStatusAsString == "L" && RepairIDAsString != "0" && RepairIDAsString != "" && RepairDateAsString != "" && CustEmailAsString != "" && CanConvertID == true && ContainsAt == true)
            {
                MessageBox.Show("The following repair was logged to the system:\n" + "Repair Status: " + RepairStatusAsString + "\nRepair ID: " + RepairIDAsString + "\nRepairDateAsString: " + RepairDateAsString + "\nCustomer Email: " + CustEmailAsString, "Logged Repair Details", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtRepairStatus.ResetText();
                txtRepairID.ResetText();
                txtRepairDate.ResetText();
                txtCustomerEmail.ResetText();
            }

            else if(RepairStatusAsString == "")
            {
                MessageBox.Show("Repair status cannot be empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairStatus.Focus();
            }
 
            else if(RepairStatusAsString != "L")
            {
                MessageBox.Show("Repair status must be 'L'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairStatus.ResetText();
                txtRepairStatus.Focus();
            }

            else if(RepairIDAsString == "")
            {
                MessageBox.Show("Repair ID cannot be empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
            }

            else if(RepairIDAsString == "0")
            {
                MessageBox.Show("Repair ID cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                txtRepairID.ResetText();
            }

            else if(CanConvertID==false)
            {
                MessageBox.Show("Repair ID must be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                txtRepairID.ResetText();
            }

            else if(RepairDateAsString == "")
            {
                MessageBox.Show("Repair Date cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairDate.Focus();
                txtRepairDate.ResetText();
            }

            else if(CustEmailAsString == "")
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
        }
    }
}

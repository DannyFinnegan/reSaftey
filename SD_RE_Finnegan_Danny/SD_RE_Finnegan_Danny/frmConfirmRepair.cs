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
    public partial class frmConfirmRepair : Form
    {
        public frmConfirmRepair(frmRepair_Menu frmRepair_Menu)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int Number = Rand.Next(1, 3);
            String CustEmailAsString = txtCustomerEmail.Text;
            bool ContainsAt = CustEmailAsString.Contains("@gmail.com");

            if (CustEmailAsString != "" && Number == 1 && ContainsAt == true)
            {
                MessageBox.Show("The customer has requested that the repair be completed", "Complete Repair", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerEmail.ResetText();
            }
            else if (CustEmailAsString != "" && Number == 2)
            {
                MessageBox.Show("The customer has requested that the repair not be completed", "Cancel Repair", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}

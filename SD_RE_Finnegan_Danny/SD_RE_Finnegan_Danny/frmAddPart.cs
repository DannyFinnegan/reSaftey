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
    public partial class frmAddPart : Form
    {
        int Counter = 1;
        public frmAddPart(frmPart_Menu frmPart_Menu)
        {
            InitializeComponent();
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            cboPartType.Items.Add("USB");
            cboPartType.Items.Add("Screen");
            cboPartType.Items.Add("Speaker");
            cboPartType.Items.Add("TrackPad");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String PartDescriptionAsString = txtPartDescription.Text;
            String PartCostAsString = txtPartCost.Text;
            String PartStockAsString = txtPartStock.Text;
            bool CanConvertCost = int.TryParse(PartCostAsString, out _);
            bool CanConvertStock = int.TryParse(PartStockAsString, out _);
            if (cboPartType.SelectedIndex > -1 && !(PartDescriptionAsString == "") && !(PartCostAsString == "") && !(PartStockAsString == "") && CanConvertCost == true && CanConvertStock == true)
            {
                MessageBox.Show("The following part was added to the databse:\n\n" + "Part Type:" + cboPartType.Items[cboPartType.SelectedIndex] + "\n" + "Part Description: " + PartDescriptionAsString + "\n" + "Part Cost: " + PartCostAsString + "\n" + "Part Stock: " + PartStockAsString + "\n" + "Part ID: " + Counter, "Part Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPartType.SelectedIndex = -1;
                txtPartDescription.ResetText();
                txtPartCost.ResetText();
                txtPartStock.ResetText();
                Counter++;
            }

            else if (cboPartType.SelectedIndex == -1)
            {
                MessageBox.Show("A part type must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (PartDescriptionAsString == "")
            {
                MessageBox.Show("Part must have a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartDescription.Focus();
            }

            else if (PartCostAsString == "")
            {
                MessageBox.Show("Part must have a cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartCost.Focus();
            }

            else if (CanConvertCost == false)
            {
                MessageBox.Show("Cost must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartCost.ResetText();
                txtPartCost.Focus();
            }

            else if (PartStockAsString == "")
            {
                MessageBox.Show("Part must have a Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartStock.Focus();
            }

            else if (CanConvertStock == false)
            {
                MessageBox.Show("Stock must be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartStock.ResetText();
                txtPartStock.Focus();

            }
        }
    }
}

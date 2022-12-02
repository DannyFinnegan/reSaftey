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
    public partial class frmUpdate_Part : Form
    {
        public frmUpdate_Part(frmPart_Menu frmPart_Menu)
        {
            InitializeComponent();
        }

        private void PartNum_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String PartIdAsString = txtPartId.Text;
            String PartDescriptionAsString = txtPartDescription.Text;
            String PartCostAsString = txtPartCost.Text;
            String PartStockAsString = txtPartStock.Text;
            bool CanConvertID = int.TryParse(PartIdAsString, out _);
            bool CanConvertCost = int.TryParse(PartCostAsString, out _);
            bool CanConvertStock = int.TryParse(PartStockAsString, out _);
            if (!(PartIdAsString == "") && CanConvertID == true && cboPartType.SelectedIndex > -1 && !(PartDescriptionAsString == "") && !(PartCostAsString == "") && !(PartStockAsString == "") && CanConvertCost == true && CanConvertStock == true)
            {
                MessageBox.Show("The following part was updated in the databse:\n\n" +"Part ID:  " + PartIdAsString + "\n\nPartType:" + cboPartType.Items[cboPartType.SelectedIndex] + "\n" + "Part Description: " + PartDescriptionAsString + "\n" + "Part Cost: " + PartCostAsString + "\n" + "Part Stock: " + PartStockAsString,"Part Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPartId.ResetText();
                cboPartType.SelectedIndex = -1;
                txtPartDescription.ResetText();
                txtPartCost.ResetText();
                txtPartStock.ResetText();
            }

            else if(PartIdAsString == "")
            {
                MessageBox.Show("Part must have a ID", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPartId.Focus();
            }

            else if (CanConvertID == false)
            {
                MessageBox.Show("ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartId.ResetText();
                txtPartId.Focus();
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

        private void txtPartNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPartType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Part_Load(object sender, EventArgs e)
        {
            cboPartType.Items.Add("USB");
            cboPartType.Items.Add("Screen");
            cboPartType.Items.Add("Speaker");
            cboPartType.Items.Add("TrackPad");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}

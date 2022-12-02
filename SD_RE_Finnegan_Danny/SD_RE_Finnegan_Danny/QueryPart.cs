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
    public partial class frmQueryPart : Form
    {
        public frmQueryPart(frmPart_Menu frmPart_Menu)
        {
            InitializeComponent();
        }

        private void QueryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int Number = Rand.Next(0, 100);
            String PartIdAsString = txtPartId.Text;
            bool CanConvertID = int.TryParse(PartIdAsString, out _);
            if(!(PartIdAsString == "") && CanConvertID==true)
            {
                MessageBox.Show("There is " + Number + " of Part ID " + PartIdAsString + " in stock", "Query Complete", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

              else if (PartIdAsString == "")
            {
                MessageBox.Show("Part must have a ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartId.Focus();
            }

            else if (CanConvertID == false)
            {
                MessageBox.Show("ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartId.ResetText();
                txtPartId.Focus();
            }
        }
    }
}

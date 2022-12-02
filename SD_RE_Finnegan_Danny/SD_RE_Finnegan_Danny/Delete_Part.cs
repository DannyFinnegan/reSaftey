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
    public partial class frmDelete_Part : Form
    {
        public frmDelete_Part(frmPart_Menu frmPart_Menu)
        {
            InitializeComponent();
        }

        private void PartNum_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            String PartIdAsString = txtPartId.Text;
            bool CanConvertID = int.TryParse(PartIdAsString, out _);

            if (!(PartIdAsString == "") && CanConvertID == true)
            {
              var result = MessageBox.Show("Are you sure wish to delete this part", "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result==DialogResult.Yes)
                {
                    MessageBox.Show("Part has been deleted", "Part Deleted",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    txtPartId.ResetText();
                }
                if(result==DialogResult.No)
                {
                    MessageBox.Show("Part has been not deleted", "Part not deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartId.ResetText();
                }
            }
             else if (PartIdAsString == "")
            {
                MessageBox.Show("Part must have a ID");
                txtPartId.Focus();
            }

            else if (CanConvertID == false)
            {
                MessageBox.Show("ID must be numeric");
                txtPartId.ResetText();
                txtPartId.Focus();
            }

        }
    }
}

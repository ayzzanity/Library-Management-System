using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmNewMember : Form
    {
        MemberManagement mm = new MemberManagement();
        public frmNewMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime exp = dtpMemDate.Value;
            if (cboType.Text == "Regular Member")
                exp = exp.AddMonths(3);
            else if(cboType.Text == "Premium Member")
                exp = exp.AddYears(1);
            mm.addMember(txtBoxFname.Text, txtBoxLname.Text, dtpMemDate.Value.ToString("yyyy/MM/dd"), exp.ToString("yyyy/MM/dd"), cboType.GetItemText(cboType.SelectedItem));
            MessageBox.Show("Member Information Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}

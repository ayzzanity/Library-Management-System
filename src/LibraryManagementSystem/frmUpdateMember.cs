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
    public partial class frmUpdateMember : Form
    {
        public int mID = 0;
        MemberManagement mm = new MemberManagement();
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mm.updateMember(mID, txtBoxFname.Text, txtBoxLname.Text, dtpMemDate.Value.ToString("yyyy/MM/dd"), dtpExpiry.Value.ToString("yyyy/MM/dd"), cboType.GetItemText(cboType.SelectedItem));
            MessageBox.Show("Member Information Updated","Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = mm.loadMembers(mID);

            txtBoxFname.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            txtBoxLname.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            dtpMemDate.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            dtpExpiry.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            cboType.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();           
        }
    }
}

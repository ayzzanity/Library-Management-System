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
    public partial class frmAddBook : Form
    {
        BookManagement bm = new BookManagement();
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bm.addBook(txtBoxTitle.Text, txtBoxAuthor.Text, "Available");
            MessageBox.Show("Book Information Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}

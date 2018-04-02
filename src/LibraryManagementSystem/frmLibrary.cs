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
    public partial class frmLibrary : Form
    {
        MemberManagement mm = new MemberManagement();
        BookManagement bm = new BookManagement();
        BookTransactions bt = new BookTransactions();
        PublisherTransactions pt = new PublisherTransactions();
        private int mid, bid;
        public frmLibrary()
        {
            InitializeComponent();
        }
        private void frmLibrary_Load(object sender, EventArgs e)
        {
            loadMembers();
            loadBooks();
            loadPublisher();
            fillCboMembers();
            fillCboBooks();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmNewMember frm = new frmNewMember();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                loadMembers();
                fillCboMembers();
            }
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            loadMembers();
        }
        private void loadMembers()
        {
            DataSet ds = new DataSet();
            ds = mm.loadMembers();
            dgvMembers.DataSource = ds.Tables[0];
        }
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = mm.loadMembers(txtBoxSearch.Text);
            dgvMembers.DataSource = ds.Tables[0];
        }
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = bt.getBorrowedCount(Convert.ToInt32(dgvMembers.SelectedRows[0].Cells[0].Value.ToString()));
            if (Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString()) == 0)
            {
                frmUpdateMember frm = new frmUpdateMember();
                frm.mID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells[0].Value.ToString());
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    loadMembers();
                    fillCboMembers();
                }
            }
            else
                MessageBox.Show("User still has pending unreturned book(s)!", "Can't Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Are you sure to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if(ok == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                ds = bt.getBorrowedCount(Convert.ToInt32(dgvMembers.SelectedRows[0].Cells[0].Value.ToString()));
                if (Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString()) == 0)
                {
                    mm.deleteMember(Convert.ToInt32(dgvMembers.SelectedRows[0].Cells[0].Value.ToString()));
                    loadMembers();
                    MessageBox.Show("Member records has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Member still has pending unreturned book(s)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadBooks()
        {
            DataSet ds = new DataSet();
            ds = bm.loadBooks();
            dgvBooks.DataSource = ds.Tables[0];
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                loadBooks();
                fillCboBooks();
            }
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult ok2 = MessageBox.Show("Are you sure to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (ok2 == DialogResult.OK)
            {
                bm.deleteBook(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString()));
                loadBooks();
                MessageBox.Show("Book records has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void txtBoxBookSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = bm.loadBooks(txtBoxBookSearch.Text);
            dgvBooks.DataSource = ds.Tables[0];
        }

        private void btnRequestBook_Click(object sender, EventArgs e)
        {
            tabLibrary.SelectedTab = tabSupply;
        }
        private void fillCboMembers()
        {
            DataSet ds = new DataSet();
            DateTime curDate = DateTime.Today;
            ds = mm.loadNames(curDate.ToString("yyyy/MM/dd"));
            cboMember.DataSource = ds.Tables[0];
            cboMember.DisplayMember = "Fullname";
            cboMember.SelectedIndex = -1;
        }
        private void fillCboBooks()
        {
            DataSet ds = new DataSet();
            ds = bm.loadAvailBooks();
            cboBook.DataSource = ds.Tables[0];
            cboBook.DisplayMember = "Title";
            cboBook.SelectedIndex = -1;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            bt.borrowBook(bid, mid, dtpIssueDate.Value.ToString("yyyy/MM/dd"), dtpDueDate.Value.ToString("yyyy/MM/dd"));
            MessageBox.Show("Book has been issued to user", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadBorrowedList();
            loadBooks();
            fillCboBooks();
            grpBoxIssue.Visible = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            grpBoxIssue.Visible = true;
            dtpDueDate.Text = DateTime.Today.AddDays(7).ToString("yyyy/MM/dd");
            btnOK.Enabled = false;
        }
        private void cboBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = bm.loadBooks(cboBook.GetItemText(cboBook.SelectedItem));
            bid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            if (cboMember.SelectedIndex != -1 && cboBook.SelectedIndex != -1)
                btnOK.Enabled = true;
        }
        private void cboMember_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = mm.loadMembers(cboMember.GetItemText(cboMember.SelectedItem));
            mid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            loadBorrowedList();
            if (cboMember.SelectedIndex != -1 && cboBook.SelectedIndex != -1)
                btnOK.Enabled = true;
        }
        private void dgvBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = mm.loadMembers(dgvBorrowed.SelectedRows[0].Cells[0].Value.ToString());
            mid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            ds = bm.loadBooks(dgvBorrowed.SelectedRows[0].Cells[1].Value.ToString());
            bid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            grpBoxReturn.Visible = true;
            ds = bt.loadBorrowedBookInfo(bid, mid);
            dtpIssue.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            dtpDue.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            bt.returnBook(bid, mid, dtpReturn.Value.ToString("yyyy/MM/dd"));
            loadBorrowedList();
            loadBooks();
            fillCboBooks();
            MessageBox.Show("Book has been returned", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpBoxReturn.Visible = false;
        }
        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = bt.loadBorrowedList();
            dgvBorrowed.DataSource = ds.Tables[0];
        }
        private void loadBorrowedList()
        {
            DataSet ds = new DataSet();
            ds = bt.loadBorrowedList(mid);
            dgvBorrowed.DataSource = ds.Tables[0];
        }
        private void cboPublisher_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = pt.loadBooks(cboPublisher.GetItemText(cboPublisher.SelectedItem));
            dgvSupplierBooks.DataSource = ds.Tables[0];
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSupplierBooks.SelectedRows[0].Cells[0].Value.ToString());
            string title = dgvSupplierBooks.SelectedRows[0].Cells[3].Value.ToString();
            string author = dgvSupplierBooks.SelectedRows[0].Cells[4].Value.ToString();
            bm.addBook(title, author, "Available");
            MessageBox.Show("Book has been added to your library", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadBooks();
            tabLibrary.SelectedTab = tabBooks;
        }
        private void btnViewPubBooks_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = pt.loadBooks("");
            dgvSupplierBooks.DataSource = ds.Tables[0];
        }

        private void btnIssueMember_Click(object sender, EventArgs e)
        {
            cboMember.SelectedIndex = dgvMembers.CurrentCell.RowIndex;
            DataSet ds = new DataSet();
            ds = mm.loadMembers(cboMember.GetItemText(cboMember.SelectedItem));
            mid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            tabLibrary.SelectedTab = tabBookTransactions;
            loadBorrowedList();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows[0].Cells[3].Value.ToString() == "Available")
            {
                cboBook.SelectedIndex = dgvBooks.CurrentCell.RowIndex;
                DataSet ds = new DataSet();
                ds = bm.loadBooks(cboBook.GetItemText(cboBook.SelectedItem));
                bid = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                tabLibrary.SelectedTab = tabBookTransactions;
            }
            else
            {
                MessageBox.Show("Book is not available", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void loadPublisher()
        {
            DataSet ds = new DataSet();
            ds = pt.loadBooks("");
            dgvSupplierBooks.DataSource = ds.Tables[0];
            ds = pt.loadPublishers();
            cboPublisher.DataSource = ds.Tables[0];
            cboPublisher.DisplayMember = "publishername";
            cboPublisher.SelectedIndex = -1;
        }
    }
}

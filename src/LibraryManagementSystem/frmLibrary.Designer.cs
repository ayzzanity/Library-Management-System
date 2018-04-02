namespace LibraryManagementSystem
{
    partial class frmLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibrary));
            this.tabLibrary = new System.Windows.Forms.TabControl();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpBoxMemberControls = new System.Windows.Forms.GroupBox();
            this.btnIssueMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewAllBook = new System.Windows.Forms.Button();
            this.txtBoxBookSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxBookControls = new System.Windows.Forms.GroupBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnRequestBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tabBookTransactions = new System.Windows.Forms.TabPage();
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxReturn = new System.Windows.Forms.GroupBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxIssue = new System.Windows.Forms.GroupBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBorrowedBooks = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.tabSupply = new System.Windows.Forms.TabPage();
            this.grpBoxAvail = new System.Windows.Forms.GroupBox();
            this.dgvSupplierBooks = new System.Windows.Forms.DataGridView();
            this.PBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnViewPubBooks = new System.Windows.Forms.Button();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.tabLibrary.SuspendLayout();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.grpBoxSearch.SuspendLayout();
            this.grpBoxMemberControls.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBoxBookControls.SuspendLayout();
            this.tabBookTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            this.grpBoxReturn.SuspendLayout();
            this.grpBoxIssue.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSupply.SuspendLayout();
            this.grpBoxAvail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierBooks)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLibrary
            // 
            this.tabLibrary.Controls.Add(this.tabMembers);
            this.tabLibrary.Controls.Add(this.tabBooks);
            this.tabLibrary.Controls.Add(this.tabBookTransactions);
            this.tabLibrary.Controls.Add(this.tabSupply);
            this.tabLibrary.Location = new System.Drawing.Point(12, 54);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.SelectedIndex = 0;
            this.tabLibrary.Size = new System.Drawing.Size(860, 395);
            this.tabLibrary.TabIndex = 0;
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Controls.Add(this.grpBoxSearch);
            this.tabMembers.Controls.Add(this.grpBoxMemberControls);
            this.tabMembers.Location = new System.Drawing.Point(4, 22);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(852, 369);
            this.tabMembers.TabIndex = 0;
            this.tabMembers.Text = "Member Management";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.Firstname,
            this.Lastname,
            this.MembershipDate,
            this.ExpiryDate,
            this.MembershipType});
            this.dgvMembers.Location = new System.Drawing.Point(7, 126);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(839, 237);
            this.dgvMembers.TabIndex = 2;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "memberID";
            this.MemberID.HeaderText = "MemberID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "firstname";
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "lastname";
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // MembershipDate
            // 
            this.MembershipDate.DataPropertyName = "membershipdate";
            this.MembershipDate.HeaderText = "MembershipDate";
            this.MembershipDate.Name = "MembershipDate";
            this.MembershipDate.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "expirydate";
            this.ExpiryDate.HeaderText = "ExpiryDate";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // MembershipType
            // 
            this.MembershipType.DataPropertyName = "membershiptype";
            this.MembershipType.HeaderText = "MembershipType";
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.ReadOnly = true;
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.btnViewAll);
            this.grpBoxSearch.Controls.Add(this.txtBoxSearch);
            this.grpBoxSearch.Controls.Add(this.lblSearch);
            this.grpBoxSearch.Location = new System.Drawing.Point(7, 70);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(839, 49);
            this.grpBoxSearch.TabIndex = 1;
            this.grpBoxSearch.TabStop = false;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(470, 9);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(103, 35);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All Users";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(57, 17);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(398, 20);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // grpBoxMemberControls
            // 
            this.grpBoxMemberControls.Controls.Add(this.btnIssueMember);
            this.grpBoxMemberControls.Controls.Add(this.btnDeleteMember);
            this.grpBoxMemberControls.Controls.Add(this.btnUpdateMember);
            this.grpBoxMemberControls.Controls.Add(this.btnRegister);
            this.grpBoxMemberControls.Location = new System.Drawing.Point(7, 6);
            this.grpBoxMemberControls.Name = "grpBoxMemberControls";
            this.grpBoxMemberControls.Size = new System.Drawing.Size(839, 57);
            this.grpBoxMemberControls.TabIndex = 0;
            this.grpBoxMemberControls.TabStop = false;
            // 
            // btnIssueMember
            // 
            this.btnIssueMember.Location = new System.Drawing.Point(733, 13);
            this.btnIssueMember.Name = "btnIssueMember";
            this.btnIssueMember.Size = new System.Drawing.Size(100, 35);
            this.btnIssueMember.TabIndex = 3;
            this.btnIssueMember.Text = "Issue Book";
            this.btnIssueMember.UseVisualStyleBackColor = true;
            this.btnIssueMember.Click += new System.EventHandler(this.btnIssueMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(271, 13);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(103, 35);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(115, 13);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateMember.TabIndex = 1;
            this.btnUpdateMember.Text = "Update Member Information";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(6, 13);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 35);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register Member";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.groupBox2);
            this.tabBooks.Controls.Add(this.grpBoxBookControls);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(852, 369);
            this.tabBooks.TabIndex = 1;
            this.tabBooks.Text = "Book Management";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Author,
            this.Status});
            this.dgvBooks.Location = new System.Drawing.Point(7, 126);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(839, 237);
            this.dgvBooks.TabIndex = 3;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "bookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewAllBook);
            this.groupBox2.Controls.Add(this.txtBoxBookSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnViewAllBook
            // 
            this.btnViewAllBook.Location = new System.Drawing.Point(470, 9);
            this.btnViewAllBook.Name = "btnViewAllBook";
            this.btnViewAllBook.Size = new System.Drawing.Size(103, 35);
            this.btnViewAllBook.TabIndex = 3;
            this.btnViewAllBook.Text = "View All Books";
            this.btnViewAllBook.UseVisualStyleBackColor = true;
            // 
            // txtBoxBookSearch
            // 
            this.txtBoxBookSearch.Location = new System.Drawing.Point(57, 17);
            this.txtBoxBookSearch.Name = "txtBoxBookSearch";
            this.txtBoxBookSearch.Size = new System.Drawing.Size(398, 20);
            this.txtBoxBookSearch.TabIndex = 1;
            this.txtBoxBookSearch.TextChanged += new System.EventHandler(this.txtBoxBookSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // grpBoxBookControls
            // 
            this.grpBoxBookControls.Controls.Add(this.btnIssueBook);
            this.grpBoxBookControls.Controls.Add(this.btnRequestBook);
            this.grpBoxBookControls.Controls.Add(this.btnDeleteBook);
            this.grpBoxBookControls.Controls.Add(this.btnAddBook);
            this.grpBoxBookControls.Location = new System.Drawing.Point(7, 6);
            this.grpBoxBookControls.Name = "grpBoxBookControls";
            this.grpBoxBookControls.Size = new System.Drawing.Size(839, 57);
            this.grpBoxBookControls.TabIndex = 2;
            this.grpBoxBookControls.TabStop = false;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(733, 13);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(100, 35);
            this.btnIssueBook.TabIndex = 3;
            this.btnIssueBook.Text = "Issue to Member";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnRequestBook
            // 
            this.btnRequestBook.Location = new System.Drawing.Point(222, 13);
            this.btnRequestBook.Name = "btnRequestBook";
            this.btnRequestBook.Size = new System.Drawing.Size(123, 35);
            this.btnRequestBook.TabIndex = 2;
            this.btnRequestBook.Text = "Request for New Book";
            this.btnRequestBook.UseVisualStyleBackColor = true;
            this.btnRequestBook.Click += new System.EventHandler(this.btnRequestBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(115, 13);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(6, 13);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(103, 35);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tabBookTransactions
            // 
            this.tabBookTransactions.Controls.Add(this.dgvBorrowed);
            this.tabBookTransactions.Controls.Add(this.grpBoxReturn);
            this.tabBookTransactions.Controls.Add(this.grpBoxIssue);
            this.tabBookTransactions.Controls.Add(this.groupBox3);
            this.tabBookTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabBookTransactions.Name = "tabBookTransactions";
            this.tabBookTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookTransactions.Size = new System.Drawing.Size(852, 369);
            this.tabBookTransactions.TabIndex = 2;
            this.tabBookTransactions.Text = "Issue / Return Book";
            this.tabBookTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fullname,
            this.Book,
            this.BorrowedDate});
            this.dgvBorrowed.Location = new System.Drawing.Point(558, 62);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.ReadOnly = true;
            this.dgvBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowed.Size = new System.Drawing.Size(288, 301);
            this.dgvBorrowed.TabIndex = 8;
            this.dgvBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowed_CellContentClick);
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Book
            // 
            this.Book.DataPropertyName = "title";
            this.Book.HeaderText = "Book";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            // BorrowedDate
            // 
            this.BorrowedDate.DataPropertyName = "borrowdate";
            this.BorrowedDate.HeaderText = "BorrowedDate";
            this.BorrowedDate.Name = "BorrowedDate";
            this.BorrowedDate.ReadOnly = true;
            // 
            // grpBoxReturn
            // 
            this.grpBoxReturn.Controls.Add(this.dtpReturn);
            this.grpBoxReturn.Controls.Add(this.lblReturn);
            this.grpBoxReturn.Controls.Add(this.btnReturn);
            this.grpBoxReturn.Controls.Add(this.dtpDue);
            this.grpBoxReturn.Controls.Add(this.label2);
            this.grpBoxReturn.Controls.Add(this.dtpIssue);
            this.grpBoxReturn.Controls.Add(this.label3);
            this.grpBoxReturn.Location = new System.Drawing.Point(6, 211);
            this.grpBoxReturn.Name = "grpBoxReturn";
            this.grpBoxReturn.Size = new System.Drawing.Size(544, 152);
            this.grpBoxReturn.TabIndex = 7;
            this.grpBoxReturn.TabStop = false;
            this.grpBoxReturn.Text = "Return Book";
            this.grpBoxReturn.Visible = false;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(223, 77);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(133, 20);
            this.dtpReturn.TabIndex = 8;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(156, 83);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(68, 13);
            this.lblReturn.TabIndex = 7;
            this.lblReturn.Text = "Return Date:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(198, 111);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 35);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpDue
            // 
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(312, 38);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(133, 20);
            this.dtpDue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due Date:";
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(83, 38);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(133, 20);
            this.dtpIssue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Issue Date:";
            // 
            // grpBoxIssue
            // 
            this.grpBoxIssue.Controls.Add(this.btnIssue);
            this.grpBoxIssue.Controls.Add(this.dtpDueDate);
            this.grpBoxIssue.Controls.Add(this.lblDueDate);
            this.grpBoxIssue.Controls.Add(this.dtpIssueDate);
            this.grpBoxIssue.Controls.Add(this.lblIssueDate);
            this.grpBoxIssue.Location = new System.Drawing.Point(7, 60);
            this.grpBoxIssue.Name = "grpBoxIssue";
            this.grpBoxIssue.Size = new System.Drawing.Size(544, 152);
            this.grpBoxIssue.TabIndex = 4;
            this.grpBoxIssue.TabStop = false;
            this.grpBoxIssue.Text = "Issue Book";
            this.grpBoxIssue.Visible = false;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(198, 93);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(103, 35);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(312, 38);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(133, 20);
            this.dtpDueDate.TabIndex = 3;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(245, 44);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(83, 38);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(133, 20);
            this.dtpIssueDate.TabIndex = 1;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(16, 44);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(61, 13);
            this.lblIssueDate.TabIndex = 0;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBorrowedBooks);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.cboBook);
            this.groupBox3.Controls.Add(this.cboMember);
            this.groupBox3.Controls.Add(this.lblBook);
            this.groupBox3.Controls.Add(this.lblMember);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 49);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue / Return Book";
            // 
            // btnBorrowedBooks
            // 
            this.btnBorrowedBooks.Location = new System.Drawing.Point(659, 9);
            this.btnBorrowedBooks.Name = "btnBorrowedBooks";
            this.btnBorrowedBooks.Size = new System.Drawing.Size(174, 35);
            this.btnBorrowedBooks.TabIndex = 5;
            this.btnBorrowedBooks.Text = "See All Borrowed Books";
            this.btnBorrowedBooks.UseVisualStyleBackColor = true;
            this.btnBorrowedBooks.Click += new System.EventHandler(this.btnBorrowedBooks_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(550, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboBook
            // 
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(326, 17);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(218, 21);
            this.cboBook.TabIndex = 4;
            this.cboBook.SelectionChangeCommitted += new System.EventHandler(this.cboBook_SelectionChangeCommitted);
            // 
            // cboMember
            // 
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(61, 17);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(218, 21);
            this.cboMember.TabIndex = 3;
            this.cboMember.SelectionChangeCommitted += new System.EventHandler(this.cboMember_SelectionChangeCommitted);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(285, 20);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(35, 13);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Book:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(7, 20);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(48, 13);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Member:";
            // 
            // tabSupply
            // 
            this.tabSupply.Controls.Add(this.grpBoxAvail);
            this.tabSupply.Controls.Add(this.groupBox5);
            this.tabSupply.Location = new System.Drawing.Point(4, 22);
            this.tabSupply.Name = "tabSupply";
            this.tabSupply.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupply.Size = new System.Drawing.Size(852, 369);
            this.tabSupply.TabIndex = 3;
            this.tabSupply.Text = "Request New Book";
            this.tabSupply.UseVisualStyleBackColor = true;
            // 
            // grpBoxAvail
            // 
            this.grpBoxAvail.Controls.Add(this.dgvSupplierBooks);
            this.grpBoxAvail.Location = new System.Drawing.Point(7, 69);
            this.grpBoxAvail.Name = "grpBoxAvail";
            this.grpBoxAvail.Size = new System.Drawing.Size(839, 294);
            this.grpBoxAvail.TabIndex = 6;
            this.grpBoxAvail.TabStop = false;
            this.grpBoxAvail.Text = "Available Books";
            // 
            // dgvSupplierBooks
            // 
            this.dgvSupplierBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSupplierBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PBookID,
            this.pubID,
            this.PTitle,
            this.PAuthor,
            this.Publisher});
            this.dgvSupplierBooks.Location = new System.Drawing.Point(6, 19);
            this.dgvSupplierBooks.Name = "dgvSupplierBooks";
            this.dgvSupplierBooks.ReadOnly = true;
            this.dgvSupplierBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierBooks.Size = new System.Drawing.Size(827, 256);
            this.dgvSupplierBooks.TabIndex = 5;
            // 
            // PBookID
            // 
            this.PBookID.DataPropertyName = "bookID";
            this.PBookID.HeaderText = "BookID";
            this.PBookID.Name = "PBookID";
            this.PBookID.ReadOnly = true;
            // 
            // pubID
            // 
            this.pubID.DataPropertyName = "publisherID";
            this.pubID.HeaderText = "PublisherID";
            this.pubID.Name = "pubID";
            this.pubID.ReadOnly = true;
            this.pubID.Visible = false;
            // 
            // PTitle
            // 
            this.PTitle.DataPropertyName = "title";
            this.PTitle.HeaderText = "Title";
            this.PTitle.Name = "PTitle";
            this.PTitle.ReadOnly = true;
            // 
            // PAuthor
            // 
            this.PAuthor.DataPropertyName = "author";
            this.PAuthor.HeaderText = "Author";
            this.PAuthor.Name = "PAuthor";
            this.PAuthor.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "publishername";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnViewPubBooks);
            this.groupBox5.Controls.Add(this.cboPublisher);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnRequest);
            this.groupBox5.Location = new System.Drawing.Point(7, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(839, 57);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnViewPubBooks
            // 
            this.btnViewPubBooks.Location = new System.Drawing.Point(397, 11);
            this.btnViewPubBooks.Name = "btnViewPubBooks";
            this.btnViewPubBooks.Size = new System.Drawing.Size(139, 35);
            this.btnViewPubBooks.TabIndex = 4;
            this.btnViewPubBooks.Text = "View All Available Books";
            this.btnViewPubBooks.UseVisualStyleBackColor = true;
            this.btnViewPubBooks.Click += new System.EventHandler(this.btnViewPubBooks_Click);
            // 
            // cboPublisher
            // 
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(64, 19);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(218, 21);
            this.cboPublisher.TabIndex = 5;
            this.cboPublisher.SelectionChangeCommitted += new System.EventHandler(this.cboPublisher_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publisher:";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(288, 11);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(103, 35);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Request Book";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            this.tabLibrary.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.grpBoxMemberControls.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxBookControls.ResumeLayout(false);
            this.tabBookTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            this.grpBoxReturn.ResumeLayout(false);
            this.grpBoxReturn.PerformLayout();
            this.grpBoxIssue.ResumeLayout(false);
            this.grpBoxIssue.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSupply.ResumeLayout(false);
            this.grpBoxAvail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierBooks)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLibrary;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpBoxMemberControls;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabBookTransactions;
        private System.Windows.Forms.TabPage tabSupply;
        private System.Windows.Forms.GroupBox grpBoxBookControls;
        private System.Windows.Forms.Button btnRequestBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewAllBook;
        private System.Windows.Forms.TextBox txtBoxBookSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpBoxIssue;
        private System.Windows.Forms.Button btnBorrowedBooks;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.GroupBox grpBoxReturn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.GroupBox grpBoxAvail;
        private System.Windows.Forms.DataGridView dgvSupplierBooks;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.Button btnViewPubBooks;
        private System.Windows.Forms.Button btnIssueMember;
        private System.Windows.Forms.Button btnIssueBook;
    }
}


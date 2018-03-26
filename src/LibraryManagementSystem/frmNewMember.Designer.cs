namespace LibraryManagementSystem
{
    partial class frmNewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMember));
            this.lblAddNewMember = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMemDate = new System.Windows.Forms.Label();
            this.lblMemType = new System.Windows.Forms.Label();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.txtBoxLname = new System.Windows.Forms.TextBox();
            this.dtpMemDate = new System.Windows.Forms.DateTimePicker();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddNewMember
            // 
            this.lblAddNewMember.AutoSize = true;
            this.lblAddNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewMember.Location = new System.Drawing.Point(214, 13);
            this.lblAddNewMember.Name = "lblAddNewMember";
            this.lblAddNewMember.Size = new System.Drawing.Size(149, 20);
            this.lblAddNewMember.TabIndex = 0;
            this.lblAddNewMember.Text = "Add New Member";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(67, 81);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "FirstName";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(66, 123);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(55, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "LastName";
            // 
            // lblMemDate
            // 
            this.lblMemDate.AutoSize = true;
            this.lblMemDate.Location = new System.Drawing.Point(66, 165);
            this.lblMemDate.Name = "lblMemDate";
            this.lblMemDate.Size = new System.Drawing.Size(93, 13);
            this.lblMemDate.TabIndex = 3;
            this.lblMemDate.Text = "Membership Date:";
            // 
            // lblMemType
            // 
            this.lblMemType.AutoSize = true;
            this.lblMemType.Location = new System.Drawing.Point(66, 207);
            this.lblMemType.Name = "lblMemType";
            this.lblMemType.Size = new System.Drawing.Size(94, 13);
            this.lblMemType.TabIndex = 4;
            this.lblMemType.Text = "Membership Type:";
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Location = new System.Drawing.Point(168, 78);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(257, 20);
            this.txtBoxFname.TabIndex = 5;
            // 
            // txtBoxLname
            // 
            this.txtBoxLname.Location = new System.Drawing.Point(168, 123);
            this.txtBoxLname.Name = "txtBoxLname";
            this.txtBoxLname.Size = new System.Drawing.Size(257, 20);
            this.txtBoxLname.TabIndex = 6;
            // 
            // dtpMemDate
            // 
            this.dtpMemDate.Location = new System.Drawing.Point(168, 159);
            this.dtpMemDate.Name = "dtpMemDate";
            this.dtpMemDate.Size = new System.Drawing.Size(257, 20);
            this.dtpMemDate.TabIndex = 7;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Regular Member",
            "Premium Member"});
            this.cboType.Location = new System.Drawing.Point(167, 198);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(258, 21);
            this.cboType.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 340);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.dtpMemDate);
            this.Controls.Add(this.txtBoxLname);
            this.Controls.Add(this.txtBoxFname);
            this.Controls.Add(this.lblMemType);
            this.Controls.Add(this.lblMemDate);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblAddNewMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewMember;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblMemDate;
        private System.Windows.Forms.Label lblMemType;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.TextBox txtBoxLname;
        private System.Windows.Forms.DateTimePicker dtpMemDate;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAdd;
    }
}
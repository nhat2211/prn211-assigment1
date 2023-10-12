namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMemberList = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberId = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbCountry = new CheckBox();
            cbCity = new CheckBox();
            groupFilter = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.AllowUserToOrderColumns = true;
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(161, 333);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(710, 256);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            dgvMemberList.CellValueChanged += dgvMemberList_CellValueChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(240, 284);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(363, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(492, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(624, 284);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 135);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 7;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 59);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 142);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 220);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 220);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Country";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(227, 56);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(168, 27);
            txtMemberId.TabIndex = 12;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(227, 135);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(168, 27);
            txtMemberName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(591, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(591, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(168, 27);
            txtPassword.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(227, 213);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(168, 27);
            txtCity.TabIndex = 16;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(591, 220);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(168, 27);
            txtCountry.TabIndex = 17;
            // 
            // cbCountry
            // 
            cbCountry.AutoSize = true;
            cbCountry.Location = new Point(20, 45);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(82, 24);
            cbCountry.TabIndex = 19;
            cbCountry.Text = "Country";
            cbCountry.UseVisualStyleBackColor = true;
            cbCountry.Click += cbCountry_Click;
            // 
            // cbCity
            // 
            cbCity.AutoSize = true;
            cbCity.Location = new Point(20, 86);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(56, 24);
            cbCity.TabIndex = 20;
            cbCity.Text = "City";
            cbCity.UseVisualStyleBackColor = true;
            cbCity.Click += cbCity_Click;
            // 
            // groupFilter
            // 
            groupFilter.Controls.Add(cbCity);
            groupFilter.Controls.Add(cbCountry);
            groupFilter.Location = new Point(834, 59);
            groupFilter.Name = "groupFilter";
            groupFilter.Size = new Size(218, 149);
            groupFilter.TabIndex = 21;
            groupFilter.TabStop = false;
            groupFilter.Text = "Filter";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 624);
            Controls.Add(groupFilter);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvMemberList);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupFilter.ResumeLayout(false);
            groupFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtMemberName;
        private TextBox txtMemberId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupFilter;
        private CheckBox cbCity;
        private CheckBox cbCountry;
    }
}
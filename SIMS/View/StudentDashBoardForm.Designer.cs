namespace SIMS.View
{
    partial class StudentDashBoardForm
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
            groupBox2 = new GroupBox();
            dvgOffers = new DataGridView();
            btnRegister = new Button();
            lblTitle = new Label();
            grpLogin = new GroupBox();
            btnRefresh = new Button();
            dgvApplications = new DataGridView();
            lblUsername = new Label();
            btnLogout = new Button();
            lblWelcome = new Label();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgOffers).BeginInit();
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbFilter);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(dvgOffers);
            groupBox2.Controls.Add(btnRegister);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 340);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Available Internships";
            // 
            // dvgOffers
            // 
            dvgOffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOffers.Location = new Point(3, 106);
            dvgOffers.Name = "dvgOffers";
            dvgOffers.RowHeadersWidth = 51;
            dvgOffers.Size = new Size(348, 142);
            dvgOffers.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(161, 288);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 38);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Apply";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnApply_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(80, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(547, 38);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Student Internship Management System";
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(btnRefresh);
            grpLogin.Controls.Add(dgvApplications);
            grpLogin.Controls.Add(lblUsername);
            grpLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(429, 83);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(360, 340);
            grpLogin.TabIndex = 7;
            grpLogin.TabStop = false;
            grpLogin.Text = "My Applications and Evaluations";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(180, 288);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(159, 38);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvApplications
            // 
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Location = new Point(6, 75);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.Size = new Size(348, 173);
            dgvApplications.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(18, 59);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(660, 11);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 39);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.SteelBlue;
            lblWelcome.Location = new Point(172, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(346, 25);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "WELCOME TO YOUR STUDENT PORTAL";
            lblWelcome.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(108, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(241, 31);
            txtSearch.TabIndex = 6;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(108, 67);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(241, 33);
            cmbFilter.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 8;
            label1.Text = "Search :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Filter :";
            // 
            // StudentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(groupBox2);
            Controls.Add(lblTitle);
            Controls.Add(grpLogin);
            Name = "StudentDashBoardForm";
            Text = "StudentDashBoardForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgOffers).EndInit();
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label lblTitle;
        private GroupBox grpLogin;
        private DataGridView dgvApplications;
        private Label lblUsername;
        private Button btnLogout;
        private Label lblWelcome;
        private Button btnRefresh;
        private DataGridView dvgOffers;
        private Button btnRegister;
        private Button btnApply;
        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
    }
}
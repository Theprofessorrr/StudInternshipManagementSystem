namespace SIMS.View
{
    partial class CompanyDashboardForm
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
            lblWelcome = new Label();
            btnLogout = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnSaveEvaluation = new Button();
            lblGrade = new Label();
            numGrade = new NumericUpDown();
            lblAcceptedItems = new Label();
            lblRemarks = new Label();
            cmbAcceptedInterns = new ComboBox();
            txtRemarks = new TextBox();
            btnAceptApp = new Button();
            dgvIncomingApplications = new DataGridView();
            btnRejectApp = new Button();
            lblTitle = new Label();
            grpLogin = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            dgvCompanyOffers = new DataGridView();
            btnClearOffer = new Button();
            txtDepartment = new TextBox();
            txtDuration = new TextBox();
            txtTitle = new TextBox();
            btnAddOffer = new Button();
            btnUpdateOffer = new Button();
            btnDeleteOffer = new Button();
            lblUsername = new Label();
            btnRefresh = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncomingApplications).BeginInit();
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanyOffers).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.SteelBlue;
            lblWelcome.Location = new Point(225, 55);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(259, 25);
            lblWelcome.TabIndex = 15;
            lblWelcome.Text = "WELCOME TO YOUR PORTAL";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(679, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 39);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btnAceptApp);
            groupBox2.Controls.Add(dgvIncomingApplications);
            groupBox2.Controls.Add(btnRejectApp);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 334);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Students Applications";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveEvaluation);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(numGrade);
            groupBox1.Controls.Add(lblAcceptedItems);
            groupBox1.Controls.Add(lblRemarks);
            groupBox1.Controls.Add(cmbAcceptedInterns);
            groupBox1.Controls.Add(txtRemarks);
            groupBox1.Location = new Point(6, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 143);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Internship Evaluation";
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.BackColor = Color.SteelBlue;
            btnSaveEvaluation.FlatAppearance.BorderSize = 0;
            btnSaveEvaluation.FlatStyle = FlatStyle.Flat;
            btnSaveEvaluation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEvaluation.ForeColor = Color.White;
            btnSaveEvaluation.Location = new Point(232, 99);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(105, 38);
            btnSaveEvaluation.TabIndex = 12;
            btnSaveEvaluation.Text = "Save";
            btnSaveEvaluation.UseVisualStyleBackColor = false;
            btnSaveEvaluation.Click += btnSaveEvaluation_Click;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(9, 111);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(56, 20);
            lblGrade.TabIndex = 11;
            lblGrade.Text = "Grade :";
            // 
            // numGrade
            // 
            numGrade.Location = new Point(126, 103);
            numGrade.Name = "numGrade";
            numGrade.Size = new Size(76, 31);
            numGrade.TabIndex = 10;
            // 
            // lblAcceptedItems
            // 
            lblAcceptedItems.AutoSize = true;
            lblAcceptedItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcceptedItems.Location = new Point(7, 31);
            lblAcceptedItems.Name = "lblAcceptedItems";
            lblAcceptedItems.Size = new Size(119, 20);
            lblAcceptedItems.TabIndex = 9;
            lblAcceptedItems.Text = "Accepted Items :";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.Location = new Point(9, 69);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(72, 20);
            lblRemarks.TabIndex = 8;
            lblRemarks.Text = "Remarks :";
            // 
            // cmbAcceptedInterns
            // 
            cmbAcceptedInterns.FormattingEnabled = true;
            cmbAcceptedInterns.Location = new Point(126, 26);
            cmbAcceptedInterns.Name = "cmbAcceptedInterns";
            cmbAcceptedInterns.Size = new Size(147, 33);
            cmbAcceptedInterns.TabIndex = 7;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(126, 64);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(147, 31);
            txtRemarks.TabIndex = 6;
            // 
            // btnAceptApp
            // 
            btnAceptApp.BackColor = Color.SteelBlue;
            btnAceptApp.FlatAppearance.BorderSize = 0;
            btnAceptApp.FlatStyle = FlatStyle.Flat;
            btnAceptApp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptApp.ForeColor = Color.White;
            btnAceptApp.Location = new Point(245, 138);
            btnAceptApp.Name = "btnAceptApp";
            btnAceptApp.Size = new Size(105, 38);
            btnAceptApp.TabIndex = 10;
            btnAceptApp.Text = "Accept";
            btnAceptApp.UseVisualStyleBackColor = false;
            btnAceptApp.Click += btnAceptApp_Click;
            // 
            // dgvIncomingApplications
            // 
            dgvIncomingApplications.AllowUserToAddRows = false;
            dgvIncomingApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncomingApplications.Location = new Point(1, 30);
            dgvIncomingApplications.Name = "dgvIncomingApplications";
            dgvIncomingApplications.ReadOnly = true;
            dgvIncomingApplications.RowHeadersWidth = 51;
            dgvIncomingApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIncomingApplications.Size = new Size(348, 100);
            dgvIncomingApplications.TabIndex = 5;
            // 
            // btnRejectApp
            // 
            btnRejectApp.BackColor = Color.SteelBlue;
            btnRejectApp.FlatAppearance.BorderSize = 0;
            btnRejectApp.FlatStyle = FlatStyle.Flat;
            btnRejectApp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejectApp.ForeColor = Color.White;
            btnRejectApp.Location = new Point(129, 138);
            btnRejectApp.Name = "btnRejectApp";
            btnRejectApp.Size = new Size(101, 38);
            btnRejectApp.TabIndex = 4;
            btnRejectApp.Text = "Reject";
            btnRejectApp.UseVisualStyleBackColor = false;
            btnRejectApp.Click += btnRejectApp_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(80, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(547, 38);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Student Internship Management System";
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(label7);
            grpLogin.Controls.Add(label6);
            grpLogin.Controls.Add(cmbStatus);
            grpLogin.Controls.Add(label5);
            grpLogin.Controls.Add(label4);
            grpLogin.Controls.Add(label3);
            grpLogin.Controls.Add(txtDescription);
            grpLogin.Controls.Add(dgvCompanyOffers);
            grpLogin.Controls.Add(btnClearOffer);
            grpLogin.Controls.Add(txtDepartment);
            grpLogin.Controls.Add(txtDuration);
            grpLogin.Controls.Add(txtTitle);
            grpLogin.Controls.Add(btnAddOffer);
            grpLogin.Controls.Add(btnUpdateOffer);
            grpLogin.Controls.Add(btnDeleteOffer);
            grpLogin.Controls.Add(lblUsername);
            grpLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(377, 104);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(412, 334);
            grpLogin.TabIndex = 12;
            grpLogin.TabStop = false;
            grpLogin.Text = "Internship Offer Management";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 314);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 24;
            label7.Text = "Status :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 155);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 23;
            label6.Text = "Title :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(149, 301);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(140, 33);
            cmbStatus.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 189);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 22;
            label5.Text = "Department :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 229);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 21;
            label4.Text = "Duration :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 271);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 20;
            label3.Text = "Description :";
            label3.Click += label3_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(149, 264);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(140, 31);
            txtDescription.TabIndex = 16;
            // 
            // dgvCompanyOffers
            // 
            dgvCompanyOffers.AllowUserToAddRows = false;
            dgvCompanyOffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanyOffers.Location = new Point(5, 30);
            dgvCompanyOffers.Name = "dgvCompanyOffers";
            dgvCompanyOffers.ReadOnly = true;
            dgvCompanyOffers.RowHeadersWidth = 51;
            dgvCompanyOffers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanyOffers.Size = new Size(400, 100);
            dgvCompanyOffers.TabIndex = 3;
            // 
            // btnClearOffer
            // 
            btnClearOffer.BackColor = Color.SteelBlue;
            btnClearOffer.FlatAppearance.BorderSize = 0;
            btnClearOffer.FlatStyle = FlatStyle.Flat;
            btnClearOffer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearOffer.ForeColor = Color.White;
            btnClearOffer.Location = new Point(309, 291);
            btnClearOffer.Name = "btnClearOffer";
            btnClearOffer.Size = new Size(92, 33);
            btnClearOffer.TabIndex = 6;
            btnClearOffer.Text = "Clear";
            btnClearOffer.UseVisualStyleBackColor = false;
            btnClearOffer.Click += btnClearOffer_Click;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(149, 181);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(140, 31);
            txtDepartment.TabIndex = 18;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(149, 218);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(140, 31);
            txtDuration.TabIndex = 17;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(149, 144);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(140, 31);
            txtTitle.TabIndex = 19;
            // 
            // btnAddOffer
            // 
            btnAddOffer.BackColor = Color.SteelBlue;
            btnAddOffer.FlatAppearance.BorderSize = 0;
            btnAddOffer.FlatStyle = FlatStyle.Flat;
            btnAddOffer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOffer.ForeColor = Color.White;
            btnAddOffer.Location = new Point(310, 157);
            btnAddOffer.Name = "btnAddOffer";
            btnAddOffer.Size = new Size(91, 31);
            btnAddOffer.TabIndex = 8;
            btnAddOffer.Text = "Add";
            btnAddOffer.UseVisualStyleBackColor = false;
            btnAddOffer.Click += btnAddOffer_Click;
            // 
            // btnUpdateOffer
            // 
            btnUpdateOffer.BackColor = Color.SteelBlue;
            btnUpdateOffer.FlatAppearance.BorderSize = 0;
            btnUpdateOffer.FlatStyle = FlatStyle.Flat;
            btnUpdateOffer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateOffer.ForeColor = Color.White;
            btnUpdateOffer.Location = new Point(309, 203);
            btnUpdateOffer.Name = "btnUpdateOffer";
            btnUpdateOffer.Size = new Size(91, 31);
            btnUpdateOffer.TabIndex = 7;
            btnUpdateOffer.Text = "Update";
            btnUpdateOffer.UseVisualStyleBackColor = false;
            btnUpdateOffer.Click += btnUpdateOffer_Click;
            // 
            // btnDeleteOffer
            // 
            btnDeleteOffer.BackColor = Color.SteelBlue;
            btnDeleteOffer.FlatAppearance.BorderSize = 0;
            btnDeleteOffer.FlatStyle = FlatStyle.Flat;
            btnDeleteOffer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteOffer.ForeColor = Color.White;
            btnDeleteOffer.Location = new Point(309, 248);
            btnDeleteOffer.Name = "btnDeleteOffer";
            btnDeleteOffer.Size = new Size(91, 31);
            btnDeleteOffer.TabIndex = 5;
            btnDeleteOffer.Text = "Delete";
            btnDeleteOffer.UseVisualStyleBackColor = false;
            btnDeleteOffer.Click += btnDeleteOffer_Click;
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
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(679, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 38);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // CompanyDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(groupBox2);
            Controls.Add(lblTitle);
            Controls.Add(grpLogin);
            Name = "CompanyDashboardForm";
            Text = "CompanyDashboardForm";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncomingApplications).EndInit();
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanyOffers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private GroupBox groupBox2;
        private Label lblAcceptedItems;
        private Label lblRemarks;
        private ComboBox cmbAcceptedInterns;
        private TextBox txtRemarks;
        private DataGridView dgvIncomingApplications;
        private Button btnRejectApp;
        private Label lblTitle;
        private GroupBox grpLogin;
        private DataGridView dgvCompanyOffers;
        private Label lblUsername;
        private Button btnRefresh;
        private ComboBox cmbStatus;
        private Button btnAddOffer;
        private Button btnUpdateOffer;
        private Button btnClearOffer;
        private Button btnDeleteOffer;
        private TextBox txtDescription;
        private TextBox txtDuration;
        private TextBox txtDepartment;
        private TextBox txtTitle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Button btnAceptApp;
        private GroupBox groupBox1;
        private Label lblGrade;
        private NumericUpDown numGrade;
        private Button btnSaveEvaluation;
    }
}
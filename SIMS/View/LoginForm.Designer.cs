namespace SIMS.Controller
{
    partial class LoginForm
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
            grpLogin = new GroupBox();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblTitle = new Label();
            groupBox2 = new GroupBox();
            txtRegPassword = new TextBox();
            txtRegUsername = new TextBox();
            btnRegister = new Button();
            label3 = new Label();
            cmbRole = new ComboBox();
            lblRegPassword = new Label();
            lblRegUsername = new Label();
            grpLogin.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(lblUsername);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUsername);
            grpLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(430, 67);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(360, 340);
            grpLogin.TabIndex = 4;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login Form";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(151, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(18, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(18, 59);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(151, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(151, 54);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(159, 30);
            txtUsername.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(129, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(547, 38);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Student Internship Management System";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRegPassword);
            groupBox2.Controls.Add(txtRegUsername);
            groupBox2.Controls.Add(btnRegister);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbRole);
            groupBox2.Controls.Add(lblRegPassword);
            groupBox2.Controls.Add(lblRegUsername);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 340);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Register Form";
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(161, 135);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(159, 31);
            txtRegPassword.TabIndex = 6;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(161, 53);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(159, 31);
            txtRegUsername.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(161, 278);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 38);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Role :";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(161, 224);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(159, 33);
            cmbRole.TabIndex = 2;
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegPassword.Location = new Point(28, 142);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(77, 20);
            lblRegPassword.TabIndex = 1;
            lblRegPassword.Text = "Password :";
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegUsername.Location = new Point(28, 60);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(82, 20);
            lblRegUsername.TabIndex = 0;
            lblRegUsername.Text = "Username :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(802, 433);
            Controls.Add(groupBox2);
            Controls.Add(lblTitle);
            Controls.Add(grpLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpLogin;
        private Label lblTitle;
        private GroupBox groupBox2;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblRegPassword;
        private Label lblRegUsername;
        private TextBox txtRegPassword;
        private TextBox txtRegUsername;
        private Button btnRegister;
        private Label label3;
        private ComboBox cmbRole;
    }
}
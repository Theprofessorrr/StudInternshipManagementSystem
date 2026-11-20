using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Models;
using SIMS.View;

namespace SIMS.Controller
{
    public partial class LoginForm : Form

    {

        private readonly AuthController _authController;
        public LoginForm()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1; port=3306; database=internship_db; user=root; password=root";
            var userRepository = new UserRepository(connectionString);
            _authController = new AuthController(userRepository);

            cmbRole.Items.AddRange(new string[] { "Student", "Company", "Supervisor" });
            if (cmbRole.Items.Count > 0)
            {
                cmbRole.SelectedIndex = 0; // Select the first item by default
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();
            try
            {
                _authController.AddUser(username, password, role);
                MessageBox.Show("User registered successfully!");
                txtRegPassword.Clear();
                txtRegUsername.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                User user = _authController.Login(username, password);
                Form dashboard = user.role switch
                {
                    "Student" => new StudentDashBoardForm(user),
                    "Company" => new CompanyDashboardForm(user),
                    "Supervisor" => new CompanyDashboardForm(user),
                    _ => throw new InvalidOperationException("Unknown role")
                };
                txtPassword.Clear();
                this.Hide();
                dashboard.FormClosed += (s, args) => this.Show();
                dashboard.Show();

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}

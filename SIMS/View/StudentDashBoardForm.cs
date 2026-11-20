using SIMS.Controller;
using SIMS.Models;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIMS;

namespace SIMS.View
{
    public partial class StudentDashBoardForm : Form
    {
        private readonly User _currentUser;
        private readonly StudentController _studentController;

        public StudentDashBoardForm(User user)

        {

            InitializeComponent();
            _currentUser = user;
            lblWelcome.Text = $"WELCOME TO YOUR STUDENT PORTAL, {_currentUser.Username}!";

            string connectionString = "Server=127.0.0.1;Port=3306;Database=internship_db;User ID=root;Password=root;";
            var repository = new InternshipRepository(connectionString);

            _studentController = new StudentController(repository);
            InitializeFilters();
            LoadDashboard();
        }
        private void InitializeFilters()
        {
            try
            {
                cmbFilter.DataSource = _studentController.GetFilterOptions();
                cmbFilter.SelectedIndex = 0; 
            }
            catch
            {
                cmbFilter.Items.Clear();
                cmbFilter.Items.AddRange(new string[] { "All", "Open", "Closed" });
                cmbFilter.SelectedIndex = 0;
            }

            txtSearch.TextChanged += FilterOffers;
            cmbFilter.SelectedIndexChanged += FilterOffers;
        }
        private void FilterOffers(object sender, EventArgs e)
        {
            try
            {
                string filter = cmbFilter.SelectedItem?.ToString() ?? "All";
                dvgOffers.DataSource = _studentController.GetAvailableOffers(txtSearch.Text, filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering offers: {ex.Message}", "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDashboard()
        {
            try
            {
                string filter = cmbFilter.SelectedItem?.ToString() ?? "All";
                dvgOffers.DataSource = _studentController.GetAvailableOffers(txtSearch.Text, filter);
                dgvApplications.DataSource = _studentController.GetMyApplications(_currentUser.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dvgOffers.CurrentRow == null)
            {
                MessageBox.Show("Please select an internship offer first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int offerId = Convert.ToInt32(dvgOffers.CurrentRow.Cells["offerId"].Value);
                _studentController.ApplyForInternship(_currentUser.UserId, offerId);

                MessageBox.Show("Application submitted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Application Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cmbFilter.Items.Count > 0)
                cmbFilter.SelectedIndex = 0;

            LoadDashboard();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

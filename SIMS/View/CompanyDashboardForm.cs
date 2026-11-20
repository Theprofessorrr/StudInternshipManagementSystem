using System;
using System.Data;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Models;
using SIMS.Repositories;

namespace SIMS.View
{
    public partial class CompanyDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly CompanyController _companyController;
        private int _selectedOfferId = 0;

        public CompanyDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            string connectionString = "Server=127.0.0.1;Port=3306;Database=internship_db;User ID=root;Password=root;";
            var repository = new InternshipRepository(connectionString);
            _companyController = new CompanyController(repository);

            lblWelcome.Text = $"WELCOME {_currentUser.Username.ToUpper()} ({_currentUser.role.ToUpper()} PORTAL)";

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Open", "Closed" });
            cmbStatus.SelectedIndex = 0;

            dgvCompanyOffers.CellClick += dgvCompanyOffers_CellClick;

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                dgvCompanyOffers.DataSource = _companyController.GetOffers(_currentUser.UserId, _currentUser.role);
                dgvIncomingApplications.DataSource = _companyController.GetApplications(_currentUser.UserId, _currentUser.role);

                DataTable accepted = _companyController.GetAcceptedInterns(_currentUser.UserId, _currentUser.role);
                cmbAcceptedInterns.DataSource = accepted;
                cmbAcceptedInterns.DisplayMember = "displayLabel";
                cmbAcceptedInterns.ValueMember = "applicationId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCompanyOffers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCompanyOffers.CurrentRow == null) return;

            var row = dgvCompanyOffers.CurrentRow;
            _selectedOfferId = Convert.ToInt32(row.Cells["offerId"].Value);
            txtTitle.Text = row.Cells["title"].Value?.ToString() ?? "";
            txtDepartment.Text = row.Cells["department"].Value?.ToString() ?? "";
            txtDuration.Text = row.Cells["duration"].Value?.ToString() ?? "";
            txtDescription.Text = row.Cells["description"].Value?.ToString() ?? "";
            cmbStatus.SelectedItem = row.Cells["status"].Value?.ToString() ?? "Open";
        }








        private void ClearOfferFields()
        {
            _selectedOfferId = 0;
            txtTitle.Clear();
            txtDepartment.Clear();
            txtDuration.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = 0;
        }





        private void HandleApplicationDecision(string decision)
        {
            if (dgvIncomingApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int appId = Convert.ToInt32(dgvIncomingApplications.CurrentRow.Cells["applicationId"].Value);
                _companyController.SetApplicationDecision(appId, decision);

                MessageBox.Show($"Application marked as {decision}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }








        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadDashboard();

        }

        private void btnRejectApp_Click_1(object sender, EventArgs e)
        {
            HandleApplicationDecision("Rejected");

        }

        private void btnAceptApp_Click(object sender, EventArgs e)
        {
            HandleApplicationDecision("Accepted");
        }

        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            if (cmbAcceptedInterns.SelectedValue == null)
            {
                MessageBox.Show("No accepted intern selected.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int appId = Convert.ToInt32(cmbAcceptedInterns.SelectedValue);
                int grade = Convert.ToInt32(numGrade.Value);
                _companyController.SubmitEvaluation(appId, grade, txtRemarks.Text);

                MessageBox.Show("Final evaluation saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRemarks.Clear();
                numGrade.Value = 0;
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearOffer_Click(object sender, EventArgs e)
        {
            ClearOfferFields();
        }

        private void btnDeleteOffer_Click(object sender, EventArgs e)
        {
            try
            {
                _companyController.RemoveClosedOffer(_selectedOfferId);

                MessageBox.Show("Closed offer deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearOfferFields();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            try
            {
                string status = cmbStatus.SelectedItem?.ToString() ?? "Open";
                _companyController.AddOffer(_currentUser.UserId, txtTitle.Text, txtDepartment.Text, txtDuration.Text, txtDescription.Text, status);

                MessageBox.Show("Internship offer posted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearOfferFields();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateOffer_Click(object sender, EventArgs e)
        {
            try
            {
                string status = cmbStatus.SelectedItem?.ToString() ?? "Open";
                _companyController.EditOffer(_selectedOfferId, txtTitle.Text, txtDepartment.Text, txtDuration.Text, txtDescription.Text, status);

                MessageBox.Show("Internship offer updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearOfferFields();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
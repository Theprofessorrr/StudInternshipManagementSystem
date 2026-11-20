using System;
using System.Data;
using SIMS.Repositories;

namespace SIMS.Controller
{
    public class CompanyController
    {
        private readonly InternshipRepository _repository;

        public CompanyController(InternshipRepository repository)
        {
            _repository = repository;
        }

        public DataTable GetOffers(int userId, string role) => _repository.GetCompanyOffers(userId, role);

        public DataTable GetApplications(int userId, string role) => _repository.GetIncomingApplications(userId, role);

        public DataTable GetAcceptedInterns(int userId, string role) => _repository.GetAcceptedInterns(userId, role);

        public void AddOffer(int companyId, string title, string department, string duration, string description, string status)
        {
            ValidateOfferInputs(title, department, duration, status);
            _repository.CreateOffer(companyId, title.Trim(), department.Trim(), duration.Trim(), description?.Trim() ?? "", status);
        }

        public void EditOffer(int offerId, string title, string department, string duration, string description, string status)
        {
            if (offerId <= 0)
                throw new ArgumentException("Please select an internship offer from the table to update.");

            ValidateOfferInputs(title, department, duration, status);
            _repository.UpdateOffer(offerId, title.Trim(), department.Trim(), duration.Trim(), description?.Trim() ?? "", status);
        }

        public void RemoveClosedOffer(int offerId)
        {
            if (offerId <= 0)
                throw new ArgumentException("Please select an internship offer to delete.");

            _repository.DeleteClosedOffer(offerId);
        }

        public void SetApplicationDecision(int applicationId, string status)
        {
            if (applicationId <= 0)
                throw new ArgumentException("Please select a student application first.");

            if (status != "Accepted" && status != "Rejected")
                throw new ArgumentException("Status must be Accepted or Rejected.");

            _repository.UpdateApplicationStatus(applicationId, status);
        }

        public void SubmitEvaluation(int applicationId, int grade, string remarks)
        {
            if (applicationId <= 0)
                throw new ArgumentException("Please select an accepted student intern.");

            if (grade < 0 || grade > 100)
                throw new ArgumentException("Grade must be between 0 and 100.");

            if (string.IsNullOrWhiteSpace(remarks))
                throw new ArgumentException("Please enter feedback remarks before saving.");

            _repository.SaveEvaluation(applicationId, grade, remarks.Trim());
        }

        private static void ValidateOfferInputs(string title, string department, string duration, string status)
        {
            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(duration) ||
                string.IsNullOrWhiteSpace(status))
            {
                throw new ArgumentException("Title, Department, Duration, and Status are all required.");
            }
        }
    }
}
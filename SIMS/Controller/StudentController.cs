using System;
using System.Collections.Generic;
using System.Data;
using SIMS.Repositories;

namespace SIMS.Controller
{
    public class StudentController
    {
        private readonly InternshipRepository _repository;

        public StudentController(InternshipRepository repository)
        {
            _repository = repository;
        }

        public DataTable GetAvailableOffers(string keyword = "", string filter = "All")
        {
            return _repository.GetAvailableOffers(keyword, filter);
        }

        public List<string> GetFilterOptions()
        {
            return _repository.GetFilterOptions();
        }

        public DataTable GetMyApplications(int studentId)
        {
            if (studentId <= 0)
                throw new ArgumentException("Invalid student account.");

            return _repository.GetStudentApplicationsAndEvaluations(studentId);
        }

        public void ApplyForInternship(int studentId, int offerId)
        {
            if (studentId <= 0)
                throw new ArgumentException("Invalid student account.");

            if (offerId <= 0)
                throw new ArgumentException("Please select an internship offer first.");

            if (_repository.HasAlreadyApplied(studentId, offerId))
                throw new InvalidOperationException("You have already applied to this internship offer.");

            _repository.CreateApplication(studentId, offerId);
        }
    }
}
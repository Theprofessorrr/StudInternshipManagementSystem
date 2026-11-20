using System;
using System.Data;
using MySqlConnector;
using System.Collections.Generic;

namespace SIMS.Repositories 
{
    public class InternshipRepository
    {
        private readonly string _connectionString;

        public InternshipRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAvailableOffers(string keyword = "", string filter = "All")
        {
            const string sql = @"SELECT o.offerId,
                                o.title,
                                COALESCE(u.username, 'Unassigned Company') AS companyName,
                                o.department,
                                o.duration,
                                o.description,
                                o.status
                         FROM internshipoffers o
                         LEFT JOIN users u ON o.companyId = u.userId
                         WHERE (@keyword = '' OR o.title LIKE @pattern OR u.username LIKE @pattern)
                           AND (@filter = 'All' OR o.status = @filter OR o.department = @filter)
                         ORDER BY o.offerId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            string trimmed = keyword?.Trim() ?? string.Empty;
            cmd.Parameters.Add("@keyword", MySqlDbType.VarChar, 100).Value = trimmed;
            cmd.Parameters.Add("@pattern", MySqlDbType.VarChar, 102).Value = $"%{trimmed}%";
            cmd.Parameters.Add("@filter", MySqlDbType.VarChar, 50).Value = string.IsNullOrWhiteSpace(filter) ? "All" : filter;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
        public List<string> GetFilterOptions()
        {
            var options = new List<string> { "All", "Open", "Closed" };

            const string sql = @"SELECT DISTINCT department
                         FROM internshipoffers
                         WHERE department IS NOT NULL AND TRIM(department) <> ''
                         ORDER BY department";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            con.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dept = reader.GetString(0);
                if (!options.Contains(dept))
                    options.Add(dept);
            }

            return options;
        }


        public bool HasAlreadyApplied(int studentId, int offerId)
        {
            const string sql = @"SELECT COUNT(*)
                                 FROM Applications
                                 WHERE StudentId = @studentId AND OfferId = @offerId";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@studentId", MySqlDbType.Int32).Value = studentId;
            cmd.Parameters.Add("@offerId", MySqlDbType.Int32).Value = offerId;

            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public void CreateApplication(int studentId, int offerId)
        {
            const string sql = @"INSERT INTO applications (offerId, studentId, applyDate, status)
                         VALUES (@offerId, @studentId, CURDATE(), 'Pending')";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@offerId", MySqlDbType.Int32).Value = offerId;
            cmd.Parameters.Add("@studentId", MySqlDbType.Int32).Value = studentId;

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable GetStudentApplicationsAndEvaluations(int studentId)
        {
            const string sql = @"SELECT a.applicationId,
                                o.title AS internshipTitle,
                                u.username AS companyName,
                                a.applyDate,
                                a.status AS applicationStatus,
                                e.grade,
                                e.remarks,
                                e.evaluationDate
                         FROM applications a
                         INNER JOIN internshipoffers o ON a.offerId = o.offerId
                         LEFT JOIN users u ON o.companyId = u.userId
                         LEFT JOIN evaluations e ON a.applicationId = e.applicationId
                         WHERE a.studentId = @studentId
                         ORDER BY a.applicationId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@studentId", MySqlDbType.Int32).Value = studentId;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;

        }
        public DataTable GetOffers(string keyword = "", string filter = "All")
        {
            const string sql = @"SELECT o.offerId,
                                o.title,
                                COALESCE(u.username, 'Unassigned Company') AS companyName,
                                o.department,
                                o.duration,
                                o.description,
                                o.status
                         FROM internshipoffers o
                         LEFT JOIN users u ON o.companyId = u.userId
                         WHERE (@keyword = '' OR o.title LIKE @pattern OR u.username LIKE @pattern)
                           AND (@filter = 'All' OR o.status = @filter OR o.department = @filter)
                         ORDER BY o.offerId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            string trimmed = keyword?.Trim() ?? string.Empty;
            cmd.Parameters.Add("@keyword", MySqlDbType.VarChar, 100).Value = trimmed;
            cmd.Parameters.Add("@pattern", MySqlDbType.VarChar, 102).Value = $"%{trimmed}%";
            cmd.Parameters.Add("@filter", MySqlDbType.VarChar, 50).Value = string.IsNullOrWhiteSpace(filter) ? "All" : filter;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
        // --- COMPANY / COORDINATOR: OFFER CRUD ---

        public DataTable GetCompanyOffers(int userId, string role)
        {
            const string sql = @"SELECT o.offerId,
                                o.companyId,
                                COALESCE(u.username, 'Unassigned') AS companyName,
                                o.title,
                                o.department,
                                o.duration,
                                o.description,
                                o.status
                         FROM internshipoffers o
                         LEFT JOIN users u ON o.companyId = u.userId
                         WHERE (@role = 'Coordinator' OR o.companyId = @userId)
                         ORDER BY o.offerId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@role", MySqlDbType.VarChar, 30).Value = role;
            cmd.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public void CreateOffer(int companyId, string title, string department, string duration, string description, string status)
        {
            const string sql = @"INSERT INTO internshipoffers (companyId, title, department, duration, description, status)
                         VALUES (@companyId, @title, @department, @duration, @description, @status)";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@companyId", MySqlDbType.Int32).Value = companyId;
            cmd.Parameters.Add("@title", MySqlDbType.VarChar, 150).Value = title;
            cmd.Parameters.Add("@department", MySqlDbType.VarChar, 100).Value = department;
            cmd.Parameters.Add("@duration", MySqlDbType.VarChar, 50).Value = duration;
            cmd.Parameters.Add("@description", MySqlDbType.Text).Value = description;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 20).Value = status;

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void UpdateOffer(int offerId, string title, string department, string duration, string description, string status)
        {
            const string sql = @"UPDATE internshipoffers
                         SET title = @title,
                             department = @department,
                             duration = @duration,
                             description = @description,
                             status = @status
                         WHERE offerId = @offerId";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@offerId", MySqlDbType.Int32).Value = offerId;
            cmd.Parameters.Add("@title", MySqlDbType.VarChar, 150).Value = title;
            cmd.Parameters.Add("@department", MySqlDbType.VarChar, 100).Value = department;
            cmd.Parameters.Add("@duration", MySqlDbType.VarChar, 50).Value = duration;
            cmd.Parameters.Add("@description", MySqlDbType.Text).Value = description;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 20).Value = status;

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteClosedOffer(int offerId)
        {
            const string sql = @"DELETE FROM internshipoffers
                         WHERE offerId = @offerId AND status = 'Closed'";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@offerId", MySqlDbType.Int32).Value = offerId;

            con.Open();
            int affected = cmd.ExecuteNonQuery();
            if (affected == 0)
                throw new InvalidOperationException("Only offers with status 'Closed' can be deleted.");
        }

        // --- COMPANY / COORDINATOR: INCOMING APPLICATIONS ---

        public DataTable GetIncomingApplications(int userId, string role)
        {
            const string sql = @"SELECT a.applicationId,
                                o.title AS internshipTitle,
                                s.username AS studentName,
                                COALESCE(DATE_FORMAT(a.applyDate, '%Y-%m-%d'), 'N/A') AS applyDate,
                                a.status,
                                e.grade,
                                e.remarks
                         FROM applications a
                         INNER JOIN internshipoffers o ON a.offerId = o.offerId
                         INNER JOIN users s ON a.studentId = s.userId
                         LEFT JOIN evaluations e ON a.applicationId = e.applicationId
                         WHERE (@role = 'Coordinator' OR o.companyId = @userId)
                         ORDER BY a.applicationId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@role", MySqlDbType.VarChar, 30).Value = role;
            cmd.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public void UpdateApplicationStatus(int applicationId, string status)
        {
            const string sql = @"UPDATE applications
                         SET status = @status
                         WHERE applicationId = @applicationId";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@applicationId", MySqlDbType.Int32).Value = applicationId;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 20).Value = status;

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // --- COMPANY / COORDINATOR: FINAL EVALUATION ---

        public DataTable GetAcceptedInterns(int userId, string role)
        {
            const string sql = @"SELECT a.applicationId,
                                CONCAT(s.username, ' - ', o.title, ' (App #', a.applicationId, ')') AS displayLabel
                         FROM applications a
                         INNER JOIN internshipoffers o ON a.offerId = o.offerId
                         INNER JOIN users s ON a.studentId = s.userId
                         WHERE a.status = 'Accepted'
                           AND (@role = 'Coordinator' OR o.companyId = @userId)
                         ORDER BY a.applicationId DESC";

            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@role", MySqlDbType.VarChar, 30).Value = role;
            cmd.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

            con.Open();
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public void SaveEvaluation(int applicationId, int grade, string remarks)
        {
            const string checkSql = "SELECT COUNT(*) FROM evaluations WHERE applicationId = @applicationId";

            using var con = new MySqlConnection(_connectionString);
            con.Open();

            using var checkCmd = new MySqlCommand(checkSql, con);
            checkCmd.Parameters.Add("@applicationId", MySqlDbType.Int32).Value = applicationId;
            int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

            string sql = exists > 0
                ? @"UPDATE evaluations
            SET grade = @grade, remarks = @remarks, evaluationDate = CURDATE()
            WHERE applicationId = @applicationId"
                : @"INSERT INTO evaluations (applicationId, grade, remarks, evaluationDate)
            VALUES (@applicationId, @grade, @remarks, CURDATE())";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@applicationId", MySqlDbType.Int32).Value = applicationId;
            cmd.Parameters.Add("@grade", MySqlDbType.Int32).Value = grade;
            cmd.Parameters.Add("@remarks", MySqlDbType.Text).Value = remarks;
            cmd.ExecuteNonQuery();
        }
    }
}
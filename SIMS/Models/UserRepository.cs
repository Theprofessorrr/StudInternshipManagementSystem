using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;


namespace SIMS.Models
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void RegisterUser(string username, string password, string role)
        {
            const string sql = @"INSERT INTO Users (Username, Password, Role)
                VALUES (@Username, @Password, @Role);";
            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role); 
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public User GetbyUsernameAndPassword(string username, string password)
        {
            const string sql = @"SELECT * FROM Users WHERE Username = @Username AND Password = @Password; LIMIT 1;";
            using var con = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            con.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32("UserId"),
                    Username = reader.GetString("Username"),
                    Password = reader.GetString("Password"),
                    role = reader.GetString("Role")
                };
            }
            return null;
        }
    }
}

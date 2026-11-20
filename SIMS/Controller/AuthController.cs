using System;
using System.Collections.Generic;
using System.Text;
using SIMS.Models;

namespace SIMS.Controller
{

    internal class AuthController
    {
        private readonly UserRepository _userRepository;

        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(string username, string password, string role)
        {
            validateUserInput(username, password, role);
            _userRepository.RegisterUser(username, password, role);
        }
        public User Login(string username, string password)
        {
            validateUserInput(username, password, "dummyRole");
            User user = _userRepository.GetbyUsernameAndPassword(username, password);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            return user;    
        }


        public static void validateUserInput(string username, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(role))
            {
                throw new ArgumentException("Role cannot be empty.");
            }
        }
    }
}
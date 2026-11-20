using System;
using System.Collections.Generic;
using System.Text;

namespace SIMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
    }
}

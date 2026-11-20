using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIMS.Models; 

namespace SIMS.View
{
    public partial class SupervisorDashboard : Form
    {
        private readonly User _currentUser;
        public SupervisorDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }
    }
}

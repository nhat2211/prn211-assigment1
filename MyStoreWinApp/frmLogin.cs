﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (isAuthenticated(txtEmail.Text, txtPass.Text))
            {
               this.Hide();
               frmMemberManagement frmMemberManagement = new frmMemberManagement();
               frmMemberManagement.ShowDialog();
               this.Close();
            }
            else
            {
                throw new Exception("Login fail!");
            }

        }

        bool isAuthenticated(string email, string password)
        {
            IConfiguration config = getDefaultEmailAndPassConfig();
            string defaultEmail = config["DefaultAccount:Email"];
            string defaultPass = config["DefaultAccount:Password"];

            return string.Equals(email, defaultEmail, StringComparison.OrdinalIgnoreCase)
                 ? true : false;
        }

        private IConfiguration getDefaultEmailAndPassConfig()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config;
        }
    }
}

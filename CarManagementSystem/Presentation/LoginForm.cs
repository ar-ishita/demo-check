using CarManagementSystem.Middleware;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class LoginForm : Form
    {
        private AdminDB adminDB = null;

        private AdminDB adminDBInstance
        {
            get
            {
                if (adminDB == null)
                    adminDB = new AdminDB();
                return adminDB;
            }


        }
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            text_box_userID.Text = "";
            text_box_Password.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_userID)
                && Validator.IsPresent(text_box_Password))
            {
                var loginUser = GetAdminDetails();

                string errorMessage = "";
                var response = adminDBInstance.LoginCustomer(loginUser, out errorMessage);
                if (response == 1)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error Information");
                }
            }
            
            
        }

        public AdminDTO GetAdminDetails()
        {
            AdminDTO admin = new AdminDTO();
            admin.Aname = text_box_userID.Text;
            admin.Apass = text_box_Password.Text;
            return admin;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 

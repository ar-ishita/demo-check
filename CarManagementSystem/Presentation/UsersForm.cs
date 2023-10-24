using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarManagementSystem.Middleware;
using CarManagementSystem.ViewModel;

namespace CarManagementSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private UserFormDB userFormDB = null;

        private UserFormDB userFormDBInstance
        {
            get
            {
                if (userFormDB == null)
                    userFormDB = new UserFormDB();
                return userFormDB;
            }


        }
        SqlConnection con = new SqlConnection(@"Server=ISH-AR;Database=carmanagementsystem;Trusted_Connection=True;");
       
        
        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(Uid) &&
                Validator.IsPresent(Uname) &&
                Validator.IsPresent(Upass))
            {
                try
                {
                    var fetchAdminDetaiLs = GetAdminDetails();

                    string errorMessage = "";
                    var response = userFormDBInstance.AddAdminDetails(fetchAdminDetaiLs, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Admin Details Are Added.", "Updated Information");

                        populate();
                        ClearControls();

                    }

                    else
                    {
                        MessageBox.Show(errorMessage);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            List<AdminDTO> adminDetailsList = userFormDBInstance.GetAdminDetails();
            UserDGV.DataSource = adminDetailsList;
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(Uid) &&
                 Validator.IsPresent(Uname) &&
                 Validator.IsPresent(Upass))
            {
                string errorMessage = "";
                //deleting that particular record
                var response = userFormDBInstance.DeleteAdminDetails(Uid.Text, out errorMessage);

                //if the deletion is successful then response will return 1 
                if (response == 1)
                {
                    MessageBox.Show("Delete Successfully");
                    populate();
                    ClearControls();
                }

                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(Uid) &&
                 Validator.IsPresent(Uname) &&
                 Validator.IsPresent(Upass))
            {
                try
                {

                    //getting the new car details
                    var newAdminDetails = GetAdminDetails();
                    string errorMessage = "";

                    var response = userFormDBInstance.UpdateCarDetails(newAdminDetails, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Admin Details Are Updated.", "Updated Information");
                        populate();
                        ClearControls();
                    }

                    else
                    {
                        MessageBox.Show(errorMessage, "Error Information");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Uid_TextChanged(object sender, EventArgs e)
        {

        }

        public AdminDTO GetAdminDetails()
        {
            AdminDTO admin = new AdminDTO();
            admin.Id = Convert.ToInt32(Uid.Text);
            admin.Aname = Uname.Text;
            admin.Apass = Upass.Text;
            
            return admin;
        }

        public void ClearControls()
        {

            Uid.Text = String.Empty;
            Uname.Text = String.Empty;
            Upass.Text = String.Empty;
            
        }
    }
}

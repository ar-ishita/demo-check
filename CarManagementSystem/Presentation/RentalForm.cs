using CarManagementSystem.Middleware;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private RentalDB rentalDB = null;

        private RentalDB rentalDBInstance
        {
            get
            {
                if (rentalDB == null)
                    rentalDB = new RentalDB();
                return rentalDB;
            }


        }
        private CarDB carDB = null;

        private CarDB carDBInstance
        {
            get
            {
                if (carDB == null)
                    carDB = new CarDB();
                return carDB;
            }


        }

        private CustomerDB customerDB = null;

        private CustomerDB customerDBInstance
        {
            get
            {
                if (customerDB == null)
                    customerDB = new CustomerDB();
                return customerDB;
            }


        }
        

        private void populate()
        {
            List<RentalDTO> rentalDetailsList = rentalDBInstance.GetRentDetails();
            RentDGV.DataSource = rentalDetailsList;
        }

        private void UpdateOnRent()
        {
          
            var fetchRentalDetails = GetRentalDetails();

            string errorMessage = "";
            var response = carDBInstance.updateRentDetails(fetchRentalDetails.carReg, out errorMessage);

            if (response == 1)
            {
                MessageBox.Show("Rental Details Are Added.", "Updated Information");
                this.ClearControls();
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void UpdateOnRentDelete()
        {
           
            //var fetchRentalDetails = GetRentalDetails();

            string errorMessage = "";
            var response = carDBInstance.updateOnRentDeleteDetails(cb_CarReg.Text, out errorMessage);

            if (response == 1)
            {
                MessageBox.Show("Rental Details Are Added.", "Updated Information");
                this.ClearControls();
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void fillCombo()
        {
            DataTable dataTable = carDBInstance.GetAvailableCars();
            

                cb_CarReg.ValueMember = "RegNum";
                cb_CarReg.DisplayMember = "RegNum";
                cb_CarReg.DataSource = dataTable;
           

        }

        private void fillCustomerDetails()
        {
            DataTable dataTable = customerDBInstance.GetAllCustomers();

            cb_CustId.ValueMember = "CustId";
            cb_CustId.DataSource = dataTable;
        }

        private void fetchCustomerDetails()
        {
            int customerId = (int)cb_CustId.SelectedValue;
            DataTable dataTable = customerDBInstance.GetCustomerDetails(customerId);
            if (dataTable.Rows.Count > 0)
            {
                text_box_Name.Text = dataTable.Rows[0]["CustName"].ToString();
            }
            else
            {
                text_box_Name.Text = string.Empty;
            }
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            fillCombo();
            fillCustomerDetails();
            populate();
        }

        private void cb_CarReg_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cb_CustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustomerDetails();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(text_box_Id) &&
                Validator.IsPresent(text_box_Name) &&
                Validator.IsPresent(text_box_RentPrice) &&
                cb_CarReg.SelectedItem != null &&
                cb_CustId.SelectedItem != null)
            {
                try
                {
                    var fetchRentalDetaiLs = GetRentalDetails();

                    string errorMessage = "";
                    var response = rentalDBInstance.AddRentalDetails(fetchRentalDetaiLs, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Rental Details Are Added.", "Updated Information");
                        UpdateOnRent();
                        populate();
                        fillCombo();
                        this.ClearControls();
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
            else
            {
                MessageBox.Show("Enter the Missing Values", "Error Information");
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_Id) &&
                Validator.IsPresent(text_box_Name) &&
                Validator.IsPresent(text_box_RentPrice))
            {
                try
                {

                    int rent_Id = int.Parse(text_box_Id.Text);
                    //fetching all the details of customerId mentioned
                    var selectedRentID = rentalDBInstance.GetRentalById(rent_Id);


                    if (selectedRentID != null)
                    {

                        DialogResult result = MessageBox.Show("Delete " + selectedRentID.CustName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string errorMessage = "";
                            //deleting that particular record
                            var response = rentalDBInstance.DeleteRentalDetails(selectedRentID.RentId, out errorMessage);

                            //if the deletion is successful then response will return 1 
                            if (response == 1)
                            {
                                UpdateOnRentDelete();
                                populate();
                                fillCombo();
                                this.ClearControls();
                                //populate();
                                //MessageBox.Show("Delete Successfully");
                            }

                            else
                            {
                                MessageBox.Show(errorMessage);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kindly get all the rent details", "Entry Error");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter the Missing Values", "Error Information");
            }
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_box_Id.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            cb_CarReg.Text = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            //cb_CarReg.SelectedItem = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            //cb_CustId.SelectedValue = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            text_box_Name.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            RentDate.Value = DateTime.Parse(RentDGV.SelectedRows[0].Cells[3].Value.ToString());
            ReturnDate.Value = DateTime.Parse(RentDGV.SelectedRows[0].Cells[4].Value.ToString());
            text_box_RentPrice.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        public RentalDTO GetRentalDetails()
        {
            RentalDTO rent = new RentalDTO();
            rent.RentId = Convert.ToInt32(text_box_Id.Text);
            rent.carReg = cb_CarReg.SelectedValue.ToString();
            rent.CustName = text_box_Name.Text;
            rent.RentDate = DateTime.Parse(RentDate.Text);
            rent.ReturnDate= DateTime.Parse(ReturnDate.Text);
            rent.RentFee = Convert.ToInt32(text_box_RentPrice.Text);
            return rent;
        }

        public void ClearControls()
        {
            text_box_Id.Text = String.Empty;
            cb_CarReg.SelectedValue = String.Empty;
            RentDate.Text = String.Empty;
            ReturnDate.Text = String.Empty;
            text_box_RentPrice.Text= String.Empty;
        }

        private void RentDate_ValueChanged(object sender, EventArgs e)
        {
            if (RentDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RentDate.Value = DateTime.Now;
            }
            if (RentDate.Value.Date > ReturnDate.Value.Date)
            {
                MessageBox.Show("Rent Date Cannot Be More than Return Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RentDate.Value = ReturnDate.Value;
            }
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (ReturnDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReturnDate.Value = DateTime.Now;
            }
            if (ReturnDate.Value.Date < RentDate.Value.Date)
            {
                MessageBox.Show("Return Date Cannot Be Less than Rent Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReturnDate.Value = RentDate.Value;
            }

        }
    }
}

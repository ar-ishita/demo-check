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
    public partial class CustomerForm : Form
    {
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
        public CustomerForm()
        {
            InitializeComponent();
        }
        
        private void populate()
        {
            List<CustomerDTO> customerDetailsList = customerDBInstance.GetCustomerDetails();
            CustomerDGV.DataSource = customerDetailsList;
        }
        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(text_box_Id) &&
                Validator.IsPresent(text_box_Name) &&
                Validator.IsPresent(text_box_Address) &&
                Validator.IsPresent(text_box_Phone))
            {
                try
                {
                    var fetchCustomerDetais = GetCustomerDetails();

                    string errorMessage = "";
                    var response = customerDBInstance.AddCustomerDetails(fetchCustomerDetais, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Customer Details Are Added.", "Updated Information");
                        populate();
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

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_Id) &&
               Validator.IsPresent(text_box_Name) &&
               Validator.IsPresent(text_box_Address) &&
               Validator.IsPresent(text_box_Phone))
            {
                try
                {
                    var newCustomerDetails = GetCustomerDetails();
                    string errorMessage = "";
                    var response = customerDBInstance.UpdateCustomerDetails(newCustomerDetails, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Customer Details Are Updated.", "Updated Information");
                        populate();
                        this.ClearControls();
                    }

                    else
                    {
                        MessageBox.Show(errorMessage, "Error Information");
                    }
                    //populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_box_Id.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            text_box_Name.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            text_box_Address.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            text_box_Phone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_Id) &&
               Validator.IsPresent(text_box_Name) &&
               Validator.IsPresent(text_box_Address) &&
               Validator.IsPresent(text_box_Phone))
            {
                try
                {
                    int customer_Id = int.Parse(text_box_Id.Text);
                    //fetching all the details of customerId mentioned
                    var selectedCustomer = customerDBInstance.GetCustomersById(customer_Id);


                    if (selectedCustomer != null)
                    {

                        DialogResult result = MessageBox.Show("Delete " + selectedCustomer.CustName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string errorMessage = "";
                            //deleting that particular record
                            var response = customerDB.DeleteCustomer(selectedCustomer.CustId, out errorMessage);

                            //if the deletion is successful then response will return 1 
                            if (response == 1)
                            {
                                
                                populate();
                                this.ClearControls();
                                MessageBox.Show("Delete Successfully");
                            }

                            else
                            {
                                MessageBox.Show(errorMessage);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kindly get all the customer details", "Entry Error");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public CustomerDTO GetCustomerDetails()
        {
            CustomerDTO customer = new CustomerDTO();
            customer.CustId = Convert.ToInt32(text_box_Id.Text);
            customer.CustName = text_box_Name.Text;
            customer.CustAdd = text_box_Address.Text;
            customer.Phone = text_box_Phone.Text;
            return customer;
        }

        public void ClearControls()
        {

            text_box_Id.Text = String.Empty;
            text_box_Name.Text = String.Empty;
            text_box_Address.Text = String.Empty;
            text_box_Phone.Text = String.Empty;
        }

    }
}

using CarManagementSystem.Middleware;
using CarManagementSystem.Models;
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
    public partial class CarForm : Form
    {
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
        public CarForm()
        {
            InitializeComponent();
        }
        
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_box_RegNo.Text = CarDGV.SelectedRows[0].Cells[0].Value.ToString();
            text_box_Brand.Text = CarDGV.SelectedRows[0].Cells[1].Value.ToString();
            text_box_Model.Text = CarDGV.SelectedRows[0].Cells[2].Value.ToString();
            cb_Available.SelectedItem = CarDGV.SelectedRows[0].Cells[3].Value.ToString();
            text_box_Price.Text = CarDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void populate()
        {
            List<CarDTO> carDetailsList = carDBInstance.GetCarDetails();
            CarDGV.DataSource = carDetailsList;

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_RegNo) &&
                Validator.IsPresent(text_box_Brand) &&
                Validator.IsPresent(text_box_Model) &&
                Validator.IsPresent(text_box_Price) &&
                Validator.IsDecimal(text_box_Price) &&
                 cb_Available.SelectedItem != null) {

                try
                {
                    var fetchCarDetaiLs = GetCarDetails();

                    string errorMessage = "";
                    var response = carDBInstance.AddCarDetails(fetchCarDetaiLs, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Car Details Are Added.", "Updated Information");
                        this.ClearControls();
                    }

                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter the missing details", "Error Information");
            }
        }

        

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(text_box_RegNo) &&
                 Validator.IsPresent(text_box_Brand) &&
                 Validator.IsPresent(text_box_Model) &&
                 Validator.IsPresent(text_box_Price) &&
                 Validator.IsDecimal(text_box_Price) &&
                 cb_Available.SelectedItem != null)
            {
                string errorMessage = "";
                //deleting that particular record
                var response = carDBInstance.DeleteCarDetails(text_box_RegNo.Text, out errorMessage);

                //if the deletion is successful then response will return 1 
                if (response == 1)
                {
                   
                    MessageBox.Show("Delete Successfully", "Error Information");
                    populate();
                    this.ClearControls();
                }

                else
                {
                    MessageBox.Show(errorMessage);
                }
            }

           
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(text_box_RegNo) &&
                Validator.IsPresent(text_box_Brand) &&
                Validator.IsPresent(text_box_Model) &&
                Validator.IsPresent(text_box_Price)  &&
                Validator.IsDecimal(text_box_Price) &&
                cb_Available.SelectedItem != null)
            {
                try
                {

                    //getting the new car details
                    var newCarDetails = GetCarDetails();
                    string errorMessage = "";

                    var response = carDBInstance.UpdateCarDetails(newCarDetails, out errorMessage);

                    if (response == 1)
                    {
                        MessageBox.Show("Car Details Are Updated.", "Updated Information");
                        populate();
                        this.ClearControls();
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

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cb_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (cb_Search.SelectedItem.ToString() == "Available")
            {
                flag = "YES";
            }
            else
            {
                flag = "NO";
            }
            List<CarDTO> carDetailsListSearch = carDBInstance.GetCarDetailsRefresh(flag);
            CarDGV.DataSource = carDetailsListSearch;

        }

        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public CarDTO GetCarDetails()
        {
            CarDTO car = new CarDTO();
            car.RegNum = text_box_RegNo.Text;
            car.Brand = text_box_Brand.Text;
            car.Model = text_box_Model.Text;
            car.Available = cb_Available.SelectedItem.ToString();
            car.Price = text_box_Price.Text;
            
            return car;
        }

        public void ClearControls()
        {

            text_box_RegNo.Text = String.Empty;
            text_box_Brand.Text = String.Empty;
            text_box_Model.Text = String.Empty;
            cb_Available.Text = String.Empty;
            text_box_Price.Text = String.Empty;
        }
    }
}

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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        private ReturnDB returnDB = null;

        private ReturnDB returnDBInstance
        {
            get
            {
                if (returnDB == null)
                    returnDB = new ReturnDB();
                return returnDB;
            }


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
        private void text_box_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateReturn();
        }

        private void populate()
        {
             List<RentalDTO> rentalDetailsList = rentalDBInstance.GetRentDetails();
             RentalDGV.DataSource = rentalDetailsList;
        }
        private void populateReturn()
        {
            List<ReturnDTO> returnDetailsList = returnDBInstance.GetReturnDetails();
            ReturnDGV.DataSource = returnDetailsList;
        }
        private void DeleteOnReturn()
        {
            int rentId;
            rentId = Convert.ToInt32(RentalDGV.SelectedRows[0].Cells[0].Value.ToString());
           

            string errorMessage = "";
            //deleting that particular record
            var response = rentalDBInstance.DeleteRentalDetails(rentId, out errorMessage);

            //if the deletion is successful then response will return 1 
            if (response == 1)
            {
                UpdateOnRentDelete();
                populate();
                //this.ClearControls();
                //populate();
                MessageBox.Show("Delete Successfully");
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
        }
        private void RentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RentalDGV != null)
            {
                text_box_CarReg.Text = RentalDGV.SelectedRows[0].Cells[1].Value.ToString();
                text_box_Name.Text = RentalDGV.SelectedRows[0].Cells[2].Value.ToString();
                ReturnDate.Text = RentalDGV.SelectedRows[0].Cells[4].Value.ToString();
                DateTime dateTime = ReturnDate.Value.Date;
                DateTime dateTime2 = DateTime.Now;
                TimeSpan timeSpan = dateTime2 - dateTime;
                int calculateDays = Convert.ToInt32(timeSpan.TotalDays);

                if (calculateDays <= 0)
                {
                    text_box_Delay.Text = "No Delay";
                    text_box_Fine.Text = "No Fine";
                }
                else
                {
                    text_box_Delay.Text = "" + calculateDays;
                    text_box_Fine.Text = "" + (calculateDays * 200);
                }
            }
            else
            {
                MessageBox.Show("No Data Available", "Error Information");
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

        private void button_add_Click(object sender, EventArgs e)
        {
            if (RentalDGV.DataSource != null && RentalDGV.Rows.Count > 0)
            {
                if (Validator.IsPresent(text_box_Id) &&
                    Validator.IsPresent(text_box_CarReg) &&
                    Validator.IsPresent(text_box_Name) &&
                    Validator.IsPresent(text_box_Delay) &&
                    Validator.IsPresent(text_box_Fine))
                {
                    try
                    {
                        var fetchReturnDetaiLs = GetReturnDetails();

                        string errorMessage = "";
                        var response = returnDBInstance.AddReturnDetails(fetchReturnDetaiLs, out errorMessage);

                        if (response == 1)
                        {
                            MessageBox.Show("Return Details Are Added.", "Updated Information");
                            populateReturn();
                            DeleteOnReturn();
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
            else
            {
                MessageBox.Show("There are no cars on rent", "Error Information");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
        private void UpdateOnRentDelete()
        {
            
            string errorMessage = "";
            var response = carDBInstance.updateOnRentDeleteDetails(text_box_CarReg.Text, out errorMessage);

            if (response == 1)
            {
                MessageBox.Show("Rental Details Are Added.", "Updated Information");
                //this.ClearControls();
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        public ReturnDTO GetReturnDetails()
        {
            ReturnDTO returnDetail = new ReturnDTO();
            returnDetail.ReturnId = Convert.ToInt32(text_box_Id.Text);
            returnDetail.CarReg = text_box_CarReg.Text;
            returnDetail.CustName = text_box_Name.Text;
            returnDetail.ReturnDate = DateTime.Parse(ReturnDate.Text);
            returnDetail.Delay = text_box_Delay.Text;
            returnDetail.Fine = text_box_Fine.Text;

           
            return returnDetail;
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            ReturnDate.Text = RentalDGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime dateTime = ReturnDate.Value.Date;
            DateTime dateTime2 = DateTime.Now;
            TimeSpan timeSpan = dateTime2 - dateTime;
            int calculateDays = Convert.ToInt32(timeSpan.TotalDays);

            if (calculateDays <= 0)
            {
                text_box_Delay.Text = "No Delay";
                text_box_Fine.Text = "No Fine";
            }
            else
            {
                text_box_Delay.Text = "" + calculateDays;
                text_box_Fine.Text = "" + (calculateDays * 200);
            }
        }

        public void ClearControls()
        {

            text_box_Id.Text = String.Empty;
            text_box_Name.Text = String.Empty;
            text_box_Fine.Text = String.Empty;
            text_box_CarReg.Text = String.Empty;
            text_box_Delay.Text = String.Empty;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Car_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarForm car = new CarForm();
            car.Show();
        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void button_Rental_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalForm rental = new RentalForm();
            rental.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnForm rent = new ReturnForm();
            rent.Show();
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

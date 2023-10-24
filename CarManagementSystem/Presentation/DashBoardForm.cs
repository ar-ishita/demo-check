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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=ISH-AR;Database=carmanagementsystem;Trusted_Connection=True;");
        private void DashBoard_Load(object sender, EventArgs e)
        {
            string queryCar = "SELECT COUNT(*) FROM CarTb1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryCar, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            CarLb.Text = dataTable.Rows[0][0].ToString();

            string queryCust = "SELECT COUNT(*) FROM CustomerTb1";
            SqlDataAdapter sqlDataAdapterCust = new SqlDataAdapter(queryCust, con);
            DataTable dataTableCust = new DataTable();
            sqlDataAdapterCust.Fill(dataTableCust);
            CustLb.Text = dataTableCust.Rows[0][0].ToString();

            string queryUser = "SELECT COUNT(*) FROM AdminTb1";
            SqlDataAdapter sqlDataAdapterUser = new SqlDataAdapter(queryUser, con);
            DataTable dataTableUser = new DataTable();
            sqlDataAdapterUser.Fill(dataTableUser);
            UsersLb.Text = dataTableUser.Rows[0][0].ToString();



        }

        private void label_application_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

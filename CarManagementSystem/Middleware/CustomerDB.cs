using AutoMapper;
using CarManagementSystem.Models;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CarManagementSystem.Middleware
{
    public class CustomerDB
    {
        private readonly IMapper mapper;

        public CustomerDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public List<CustomerDTO> GetCustomerDetails()
        {
            Customer customerDetails = null;
            List<Customer> customerDetailsList = new List<Customer>();
            string selectStatement = Constants.SqlStatements.customerDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                customerDetails = new Customer
                {
                    CustId = (int)reader["CustId"],
                    CustName = reader["CustName"].ToString(),
                    CustAdd = reader["CustAdd"].ToString(),
                    Phone = reader["Phone"].ToString(),
                };
                customerDetailsList.Add(customerDetails);
            }



            List<CustomerDTO> newCustomerDetails = mapper.Map<List<CustomerDTO>>(customerDetailsList);

            return newCustomerDetails;


        }
        public int AddCustomerDetails(CustomerDTO customer, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string insertStatement = Constants.SqlStatements.insertCustomerDetailsStatement;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    insertStatement, connection);
                command.Parameters.AddWithValue("@CustId", customer.CustId);
                command.Parameters.AddWithValue("@CustName", customer.CustName);
                command.Parameters.AddWithValue("@CustAdd", customer.CustAdd);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                connection.Open();
                count = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    errorMessage += "ERROR CODE: " + error.Number + " " + error.Message + "\n";
                }
            }
            catch (Exception ex)
            {
                errorMessage += $"{ex.Message}, {ex.GetType().ToString()}";
            }

            return count;
        }

        public int UpdateCustomerDetails(CustomerDTO newCustomerDetails, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string updateStatement = Constants.SqlStatements.updateCustomerDetailsStatement;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    updateStatement, connection);

                command.Parameters.AddWithValue("@CustName", newCustomerDetails.CustName);
                command.Parameters.AddWithValue("@CustAdd", newCustomerDetails.CustAdd);
                command.Parameters.AddWithValue("@Phone", newCustomerDetails.Phone);
                command.Parameters.AddWithValue("@CustId", newCustomerDetails.CustId);
                connection.Open();
                count = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    errorMessage += "ERROR CODE: " + error.Number + " " + error.Message + "\n";
                }
            }
            catch (Exception ex)
            {
                errorMessage += $"{ex.Message}, {ex.GetType().ToString()}";
            }

            return count;
        }

        public CustomerDTO GetCustomersById(int customerID)
        {
            Customer customer = null;
            string selectStatement = Constants.SqlStatements.selectCustomersDetailsById;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);
            command.Parameters.AddWithValue("@CustId", customerID);
            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                customer = new Customer
                {
                    CustId = (int)reader["CustId"],
                    CustName = reader["CustName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                   
                };
            }



            var newCustomer = mapper.Map<CustomerDTO>(customer);

            return newCustomer;


        }

        public int DeleteCustomer(int Id, out string errorMessage)
        {
            try
            {
                //getting the query
                string deleteStatement = Constants.SqlStatements.deleteCustomerDetailsById;
                //connection
                using SqlConnection connection = new Connection().SqlConnection;
                //command in which sql command and database connection on which it will be  executed.
                using SqlCommand command = new SqlCommand(deleteStatement, connection);
                //id is passed to the parameters
                command.Parameters.AddWithValue("@CustId", Id);

                connection.Open();
                //this will return the number of rows that is deleted
                int rowsDelete = command.ExecuteNonQuery();

                if (rowsDelete == 1)
                {
                    errorMessage = "";
                    return 1;
                }
                else
                {
                    errorMessage = "Error Deleting Value";
                    return 0;
                }

            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return 0;
            }


        }

        public DataTable GetAllCustomers()
        {
            string selectStatement = "SELECT CustId FROM CustomerTb1";
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(selectStatement, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
        }

        public DataTable GetCustomerDetails(int customerId)
        {
            string query = "SELECT CustName FROM CustomerTb1 WHERE CustId = @CustId";
            using (SqlConnection connection = new Connection().SqlConnection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustId", customerId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }


    }
}

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
    public class UserFormDB
    {
        private readonly IMapper mapper;

        public UserFormDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public List<AdminDTO> GetAdminDetails()
        {
            Admin adminDetails = null;
            List<Admin> adminDetailsList = new List<Admin>();
            string selectStatement = Constants.SqlStatements.adminDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                adminDetails = new Admin
                {
                    Id = (int)reader["Id"],
                    Aname = reader["Aname"].ToString(),
                    Apass = reader["Apass"].ToString(),
                   

                };
                adminDetailsList.Add(adminDetails);
            }



            List<AdminDTO> newAdminDetails = mapper.Map<List<AdminDTO>>(adminDetailsList);

            return newAdminDetails;


        }

        public int AddAdminDetails(AdminDTO admin, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string insertStatement = Constants.SqlStatements.insertAdminDetails;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    insertStatement, connection);
                command.Parameters.AddWithValue("@Id", admin.Id);
                command.Parameters.AddWithValue("@Aname", admin.Aname);
                command.Parameters.AddWithValue("@Apass", admin.Apass);
                
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

        public int UpdateCarDetails(AdminDTO newAdminDetails, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string updateStatement = Constants.SqlStatements.adminUpdateStatement;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    updateStatement, connection);

                command.Parameters.AddWithValue("@Id", newAdminDetails.Id);
                command.Parameters.AddWithValue("@Aname", newAdminDetails.Aname);
                command.Parameters.AddWithValue("@Apass", newAdminDetails.Apass);
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

        public int DeleteAdminDetails(string Id, out string errorMessage)
        {
            try
            {
                //getting the query
                string deleteStatement = Constants.SqlStatements.adminDeleteStatement;
                //connection
                using SqlConnection connection = new Connection().SqlConnection;
                //command in which sql command and database connection on which it will be  executed.
                using SqlCommand command = new SqlCommand(deleteStatement, connection);
                //id is passed to the parameters
                command.Parameters.AddWithValue("@Id", Id);

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

    }
}

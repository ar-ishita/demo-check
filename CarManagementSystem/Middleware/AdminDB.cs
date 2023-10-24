using AutoMapper;
using CarManagementSystem.Models;
using CarManagementSystem.ViewModel;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarManagementSystem.Middleware
{
    public class AdminDB
    {
        private readonly IMapper mapper;

        public AdminDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }


        public int LoginCustomer(AdminDTO admin, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            
            try
            {
                string loginStatement = Constants.SqlStatements.loginCustomer;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                            loginStatement, connection);
                command.Parameters.AddWithValue("@Aname", admin.Aname);
                command.Parameters.AddWithValue("@Apass", admin.Apass);

                connection.Open();
                count = (int)command.ExecuteScalar();
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
    }
}

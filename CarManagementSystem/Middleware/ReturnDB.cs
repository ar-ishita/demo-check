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
    public class ReturnDB
    {
        private readonly IMapper mapper;

        public ReturnDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public List<ReturnDTO> GetReturnDetails()
        {
            Return returnDetails = null;
            List<Return> returnDetailsList = new List<Return>();
            string selectStatement = Constants.SqlStatements.returnDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                returnDetails = new Return
                {
                    ReturnId = (int)reader["ReturnId"],
                    CarReg = reader["CarReg"].ToString(),
                    CustName = reader["CustName"].ToString(),
                    ReturnDate = (DateTime)reader["ReturnDate"],
                    Delay = reader["Delay"].ToString(),
                    Fine = reader["Fine"].ToString(),

                };
                returnDetailsList.Add(returnDetails);
            }



            List<ReturnDTO> newReturnDetails = mapper.Map<List<ReturnDTO>>(returnDetailsList);

            return newReturnDetails;


        }

        public int AddReturnDetails(ReturnDTO returnDetails, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string insertStatement = Constants.SqlStatements.insertReturnDetails;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    insertStatement, connection);

                command.Parameters.AddWithValue("@ReturnId", returnDetails.ReturnId);
                command.Parameters.AddWithValue("@CarReg", returnDetails.CarReg);
                command.Parameters.AddWithValue("@CustName", returnDetails.CustName);
                command.Parameters.AddWithValue("@ReturnDate", returnDetails.ReturnDate);
                command.Parameters.AddWithValue("@Delay", returnDetails.Delay);
                command.Parameters.AddWithValue("@Fine", returnDetails.Fine);

                
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
    }
}

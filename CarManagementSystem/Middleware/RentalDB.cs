using AutoMapper;
using CarManagementSystem.Models;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Drawing;

namespace CarManagementSystem.Middleware
{
    public class RentalDB
    {
        private readonly IMapper mapper;

        public RentalDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public List<RentalDTO> GetRentDetails()
        {
            Rental rentDetails = null;
            List<Rental> rentDetailsList = new List<Rental>();
            string selectStatement = Constants.SqlStatements.rentalDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                rentDetails = new Rental
                {
                    RentId = (int)reader["RentId"],
                    carReg = reader["carReg"].ToString(),
                    CustName = reader["CustName"].ToString(),
                    RentDate = (DateTime)reader["RentDate"],
                    ReturnDate = (DateTime)reader["ReturnDate"],
                    RentFee = (int)reader["RentFee"],

                };
                rentDetailsList.Add(rentDetails);
            }



            List<RentalDTO> newRentDetails = mapper.Map<List<RentalDTO>>(rentDetailsList);

            return newRentDetails;


        }

        public int AddRentalDetails(RentalDTO rental, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string insertStatement = Constants.SqlStatements.insertRentalDetails;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    insertStatement, connection);
                command.Parameters.AddWithValue("@RentId", rental.RentId);
                command.Parameters.AddWithValue("@carReg", rental.carReg);
                command.Parameters.AddWithValue("@CustName", rental.CustName);
                command.Parameters.AddWithValue("@RentDate", rental.RentDate);
                command.Parameters.AddWithValue("@ReturnDate", rental.ReturnDate);
                command.Parameters.AddWithValue("@RentFee", rental.RentFee);
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

        public RentalDTO GetRentalById(int rentId)
        {
            Rental rent = null;
            string selectStatement = Constants.SqlStatements.selectRentalDetailsById;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);
            command.Parameters.AddWithValue("@RentId", rentId);
            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                rent = new Rental
                {
                    RentId = (int)reader["RentId"],
                    carReg = reader["carReg"].ToString(),
                    CustName = reader["CustName"].ToString(),
                    RentDate = (DateTime)reader["RentDate"],
                    ReturnDate = (DateTime)reader["ReturnDate"],
                    RentFee = (int)reader["RentFee"],


                };
            }



            var newRental = mapper.Map<RentalDTO>(rent);

            return newRental;


        }

        public int DeleteRentalDetails(int Id, out string errorMessage)
        {
            try
            {
                //getting the query
                string deleteStatement = Constants.SqlStatements.deleteRentalDetailsById;
                //connection
                using SqlConnection connection = new Connection().SqlConnection;
                //command in which sql command and database connection on which it will be  executed.
                using SqlCommand command = new SqlCommand(deleteStatement, connection);
                //id is passed to the parameters
                command.Parameters.AddWithValue("@RentId", Id);

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

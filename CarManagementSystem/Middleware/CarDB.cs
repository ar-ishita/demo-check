using AutoMapper;
using CarManagementSystem.Models;
using CarManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Microsoft.VisualBasic;

namespace CarManagementSystem.Middleware
{
    public class CarDB
    {
        private readonly IMapper mapper;

        public CarDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public List<CarDTO> GetCarDetails()
        {
            Car carDetails = null;
            List<Car> carDetailsList = new List<Car>();
            string selectStatement = Constants.SqlStatements.carDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                carDetails = new Car
                {
                    RegNum = reader["RegNum"].ToString(),
                    Brand = reader["Brand"].ToString(),
                    Model = reader["Model"].ToString(),
                    Available = reader["Available"].ToString(),
                    Price = reader["Price"].ToString(),

                };
                carDetailsList.Add(carDetails); 
            }



            List<CarDTO> newCarDetails = mapper.Map<List<CarDTO>>(carDetailsList);

            return newCarDetails;


        }

        public int AddCarDetails(CarDTO cars, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string insertStatement = Constants.SqlStatements.insertCarDetailsStatement;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    insertStatement, connection);

                command.Parameters.AddWithValue("@RegNum", cars.RegNum);
                command.Parameters.AddWithValue("@Brand", cars.Brand);
                command.Parameters.AddWithValue("@Model", cars.Model);
                command.Parameters.AddWithValue("@Available", cars.Available);
                command.Parameters.AddWithValue("@Price", cars.Price);

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

        public CarDTO GetCarByRegNum(string regNum)
        {
            Car cars = null;
            string selectStatement = Constants.SqlStatements.getCarDetailsStatement;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);
            command.Parameters.AddWithValue("@RegNum", regNum);
            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                cars = new Car
                {
                    RegNum = reader["RegNum"].ToString(),
                    Brand = reader["Brand"].ToString(),
                    Model = reader["Model"].ToString(),
                    Available = reader["Available"].ToString(),
                    Price = reader["Price"].ToString(),
                    
                };
            }



            var newCarData = mapper.Map<CarDTO>(cars);

            return newCarData;


        }

        public int DeleteCarDetails(string Id, out string errorMessage)
        {
            try
            {
                //getting the query
                string deleteStatement = Constants.SqlStatements.deleteCarByRegNum;
                //connection
                using SqlConnection connection = new Connection().SqlConnection;
                //command in which sql command and database connection on which it will be  executed.
                using SqlCommand command = new SqlCommand(deleteStatement, connection);
                //id is passed to the parameters
                command.Parameters.AddWithValue("@RegNum", Id);

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

        public int UpdateCarDetails(CarDTO newCarDetails, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            //   SqlCommand command = null;
            try
            {
                string updateStatement = Constants.SqlStatements.updateCarDetailsStatement;
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(
                    updateStatement, connection);

                command.Parameters.AddWithValue("@Brand", newCarDetails.Brand);
                command.Parameters.AddWithValue("@Model", newCarDetails.Model);
                command.Parameters.AddWithValue("@Available", newCarDetails.Available);
                command.Parameters.AddWithValue("@Price", newCarDetails.Price);
                command.Parameters.AddWithValue("@RegNum", newCarDetails.RegNum);
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

        public List<CarDTO> GetCarDetailsRefresh(string flag)
        {
            Car carDetails = null;
            List<Car> carDetailsList = new List<Car>();
            string selectStatement = Constants.SqlStatements.carDetailsSearch;
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(
                selectStatement, connection);
            command.Parameters.AddWithValue("@Available", flag);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader(CommandBehavior.SingleRow &
                                      CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                carDetails = new Car
                {
                    RegNum = reader["RegNum"].ToString(),
                    Brand = reader["Brand"].ToString(),
                    Model = reader["Model"].ToString(),
                    Available = reader["Available"].ToString(),
                    Price = reader["Price"].ToString(),

                };
                carDetailsList.Add(carDetails);
            }



            List<CarDTO> newCarDetails = mapper.Map<List<CarDTO>>(carDetailsList);

            return newCarDetails;


        }

        public DataTable GetAvailableCars()
        {
            string selectStatement = "SELECT RegNum FROM CarTb1 WHERE Available = @Available";
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@Available", "YES");

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
        }


        public int updateRentDetails(string regNum, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            try { 
            string updateRentStatement = "UPDATE CarTb1 SET Available = @Available WHERE RegNum = @RegNum";
            using SqlConnection connection = new Connection().SqlConnection;
            using SqlCommand command = new SqlCommand(updateRentStatement, connection);
            command.Parameters.AddWithValue("@Available", "NO");
            command.Parameters.AddWithValue("@RegNum", regNum);
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

        public int updateOnRentDeleteDetails(string regNum, out string errorMessage)
        {
            errorMessage = string.Empty;
            var count = 0;
            try
            {
                string updateRentStatement = "UPDATE CarTb1 SET Available = @Available WHERE RegNum = @RegNum";
                using SqlConnection connection = new Connection().SqlConnection;
                using SqlCommand command = new SqlCommand(updateRentStatement, connection);
                command.Parameters.AddWithValue("@Available", "YES");
                command.Parameters.AddWithValue("@RegNum", regNum);
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

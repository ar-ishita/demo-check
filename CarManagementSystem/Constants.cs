using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagementSystem
{
    class Constants
    {
       

        public static class SqlStatements
        {

            public const string selectCustomers = "SELECT CustomerID, Name, Address, City, " +
                   "State, ZipCode " +
                   "FROM Customers ";

            public const string selectCustomersById = "SELECT CustomerID, Name, Address, City, " +
                    "State, ZipCode " +
                    "FROM Customers " +
                    "WHERE CustomerID = @CustomerID";

            public const string insertStatement = "INSERT Customers " +
                "(Name, Address, City, State, ZipCode) " +
                "VALUES (@Name, @Address, @City, @State, @ZipCode)";

            public const string deleteCustomersById = "DELETE FROM Customers WHERE CustomerID = @customerId";

            public const string getStates = "SELECT StateCode FROM STATES";

            public const string updateStatement = "UPDATE Customers SET " +
                "Name = @NewName, " + "Address = @NewAddress, " +
                "City = @NewCity, " + "State = @NewState, " +
                "ZipCode = @NewZipCode " + "WHERE CustomerID = @oldCustomerID ";

            public const string updateValue = "UPDATE Customers SET Name=@Name, Address=@Address, " +
                "City=@City, State=@State, ZipCode=@ZipCode WHERE CustomerID=@CustomerID";


            ///////////////////////
            ///
            //public const string loginCustomer = "SELECT COUNT(*) FROM AdminTb1 WHERE Aname = '" + text_box_userID.Text + "' AND Apass = '" + text_box_Password.Text + "'";

            public const string loginCustomer = "SELECT COUNT(*) FROM AdminTb1 WHERE Aname = @Aname AND Apass = @Apass";
            public const string carDetailsStatement = "SELECT * FROM CarTb1";
            public const string insertCarDetailsStatement = "INSERT CarTb1 " +
                "(RegNum, Brand, Model, Available, Price )" +
                "VALUES (@RegNum, @Brand, @Model, @Available, @Price)";
            public const string getCarDetailsStatement = "SELECT RegNum, Brand, Model, Available, Price, " +
                "FROM CarTb1 " +
                "WHERE RegNum = @RegNum";
            public const string deleteCarByRegNum = "DELETE FROM CarTb1 WHERE RegNum = @RegNum";

            public const string updateCarDetailsStatement = "UPDATE CarTb1 SET " +
                "Brand = @Brand, " + "Model = @Model, " + "Available = @Available, " + "Price = @Price " + "WHERE RegNum = @RegNum";

            public const string carDetailsSearch = "SELECT * FROM CarTb1 WHERE Available = @Available";

            
            public const string customerDetailsStatement = "SELECT * FROM CustomerTb1";
            public const string insertCustomerDetailsStatement = "INSERT CustomerTb1 " +
                "(CustId, CustName, CustAdd, Phone)" +
                "VALUES (@CustId, @CustName, @CustAdd, @Phone)";

            public const string updateCustomerDetailsStatement = "UPDATE CustomerTb1 SET " + 
                "CustName = @CustName, " + "CustAdd = @CustAdd, " + "Phone = @Phone " + "WHERE CustId = @CustId";

            public const string selectCustomersDetailsById = "SELECT CustId, CustName, CustAdd, Phone FROM CustomerTb1 WHERE CustId = @CustId";

            public const string deleteCustomerDetailsById = "DELETE FROM CustomerTb1 WHERE CustId = @CustId";


            public const string rentalDetailsStatement = "SELECT * FROM RentalTb1";
            //public const string getAvailableYes = "SELECT RegNum FROM CarTb1 WHERE Available = '" + "YES" + "'";
            public const string getAvailableYes = "SELECT RegNum FROM CarTb1 WHERE Available = @Available";

            public const string insertRentalDetails = "INSERT RentalTb1 " +
                "(RentId, carReg, CustName, RentDate, ReturnDate, RentFee)" +
                "VALUES (@RentId, @carReg, @CustName, @RentDate, @ReturnDate, @RentFee)";

            public const string selectRentalDetailsById = "SELECT RentId, carReg, CustName, RentDate, ReturnDate, RentFee FROM RentalTb1 WHERE RentId = @RentId";
            public const string deleteRentalDetailsById = "DELETE FROM RentalTb1 WHERE RentId = @RentId";
            
            
            public const string returnDetailsStatement = "SELECT * FROM ReturnTb1";
            public const string insertReturnDetails = "INSERT ReturnTb1 " +
                "(ReturnId, CarReg, CustName, ReturnDate, Delay, Fine)" +
                "VALUES (@ReturnId, @CarReg, @CustName, @ReturnDate, @Delay, @Fine)";


            public const string adminDetailsStatement = "SELECT * FROM AdminTb1";
            public const string insertAdminDetails = "INSERT AdminTb1 " +
                "(Id, Aname, Apass)" +
                "VALUES (@Id, @Aname, @Apass)";
            public const string adminUpdateStatement = "UPDATE AdminTb1 SET " +
                "Id = @Id, " + "Aname = @Aname, " + "Apass = @Apass " + "WHERE Id = @Id";


            public const string adminDeleteStatement = "DELETE FROM AdminTb1 WHERE Id = @Id";
        }



    }
}

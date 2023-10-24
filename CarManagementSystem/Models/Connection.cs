using CarManagementSystem.Middleware;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CarManagementSystem.Models
{
    public class Connection
    {
        private ConfigurationProvider configProvider = null;
        private SqlConnection _sqlConnection = null;
        private ConfigurationProvider instance
        {
            get
            {
                if (configProvider == null)
                {
                    configProvider = new ConfigurationProvider();
                }
                return configProvider;
            }
        }


        public SqlConnection SqlConnection
        {
            get
            {
                if (_sqlConnection == null)
                    _sqlConnection = new SqlConnection(instance.GetConnectionString());
                return _sqlConnection;
            }

        }

    }
}

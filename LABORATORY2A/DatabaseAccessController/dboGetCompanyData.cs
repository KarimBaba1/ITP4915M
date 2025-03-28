using System.Data;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboGetCompanyData
    {
        private readonly string _connectionString;

        public dboGetCompanyData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllCustomerData()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Customers";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable FindCustomerData(string customerName)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM customers WHERE customerName LIKE CONCAT('%',  @customerName, '%')";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}

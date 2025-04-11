using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboGetCompanyData : dboDatabaseController
    {
        private readonly string _connectionString;

        public dboGetCompanyData(string connectionString) : base (connectionString)
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
        public int UpdateCustomerData(DataTable dtUpdated)
        {
            if (dtUpdated == null || dtUpdated.Rows.Count == 0)
            {
                return 0; // No rows to update
            }
            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dtUpdated.Rows)
            {
                sb.Append($"UPDATE `customers` SET ");
                sb.Append($"`customerName` = '{row["customerName"]}', ");
                sb.Append($"`contactLastName` = '{row["contactLastName"]}', ");
                sb.Append($"`contactFirstName` = '{row["contactFirstName"]}', ");
                sb.Append($"`phone` = '{row["phone"]}', ");
                sb.Append($"`addressLine1` = '{row["addressLine1"]}', ");
                sb.Append($"`addressLine2` = '{row["addressLine2"]}', ");
                sb.Append($"`city` = '{row["city"]}', ");
                sb.Append($"`state` = '{row["state"]}', ");
                sb.Append($"`postalCode` = '{row["postalCode"]}', ");
                sb.Append($"`country` = '{row["country"]}', ");
                sb.Append($"`salesRepEmployeeNumber` = {row["salesRepEmployeeNumber"]}, ");
                sb.Append($"`creditLimit` = {row["creditLimit"]} ");
                sb.Append($"WHERE `customerNumber` = {row["customerNumber"]}; ");
            }

            return BatchUpdate(sb.ToString());
        }
        public int InsertCustomerData(DataTable dtNew)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dtNew.Rows)
            {
                sb.Append("INSERT INTO `customers` (`customerNumber`, `customerName`, `contactLastName`, `contactFirstName`, `phone`, `addressLine1`, `addressLine2`, `city`, `state`, `postalCode`, `country`, `salesRepEmployeeNumber`, `creditLimit`) VALUES (");
                sb.Append($"'{row["customerNumber"]}', ");
                sb.Append($"'{row["customerName"]}', ");
                sb.Append($"'{row["contactLastName"]}', ");
                sb.Append($"'{row["contactFirstName"]}', ");
                sb.Append($"'{row["phone"]}', ");
                sb.Append($"'{row["addressLine1"]}', ");
                sb.Append($"'{row["addressLine2"]}', ");
                sb.Append($"'{row["city"]}', ");
                sb.Append($"'{row["state"]}', ");
                sb.Append($"'{row["postalCode"]}', ");
                sb.Append($"'{row["country"]}', ");
                sb.Append($"{row["salesRepEmployeeNumber"]}, ");
                sb.Append($"{row["creditLimit"]}); ");
            }

            return BatchUpdate(sb.ToString());
        }
        public int DeleteCustomerData(string customerNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "DELETE FROM `customers` WHERE `customerNumber` = @customerNumber";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerNumber", customerNumber);

                    connection.Open();
                    return command.ExecuteNonQuery(); // Returns the number of rows affected
                }
            }
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

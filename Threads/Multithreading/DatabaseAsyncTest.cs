using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class DatabaseAsyncTest
    {
        const string connStr = "server=localhost;database=EmployeeDB;trusted_connection=True;TrustServerCertificate=True;";
        public static async Task Start()
        {
            using SqlConnection sqlConnection = new(connStr);
            sqlConnection.Open();

            var command = sqlConnection.CreateCommand();
            command.CommandText = "Select Name from [dbo].[User]";

            var reader = await command.ExecuteReaderAsync();
            await reader.ReadAsync();
            Console.Write(reader["Name"].ToString());
        }
    }
}

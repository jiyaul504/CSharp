using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnection1
{
    partial class Program
    {
        /// <summary>
        /// Main method, entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string connectionString = "Server=Jiyaul;Database=School;User Id=sa;Password=Krishna19741!;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = null;

            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from Student");
            sqlCommand.Connection = sqlConnection;
            GetRecords(sqlCommand);
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from Student where StudentID = 1");
            sqlCommand.Connection = sqlConnection;
            GetRecords(sqlCommand);
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from Student");
            sqlCommand.Connection = sqlConnection;
            var reader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Console.ForegroundColor = ConsoleColor.White;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine(dataRow["StudentID"]);
            }
            sqlConnection.Close();


            //Fetch a single value
            Console.ForegroundColor = ConsoleColor.Red;
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select count(*) from Student");
            sqlCommand.Connection = sqlConnection;
            var result = sqlCommand.ExecuteScalar();
            Console.WriteLine(result);
            sqlConnection.Close();


            //Insert or Update a record
            string commandText = "UPDATE Student set Address = '14, Car St' WHERE StudentID = 2";
            Console.WriteLine(InsertOrUpdateRecord(sqlConnection, commandText));

            commandText = "insert into student (StudentID,LastName,FirstName,[Address],City) values (5,'sundar5','shan5','17, Car St','Cbe');insert into student (StudentID,LastName,FirstName,[Address],City) values (6,'sundar6','shan6','18, Car St','Cbe')";
            Console.WriteLine(InsertOrUpdateRecord(sqlConnection, commandText));

            Console.Read();
        }

        private static int InsertOrUpdateRecord(SqlConnection sqlConnection, string commandText)
        {
            SqlCommand sqlCommand;
            sqlConnection.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = commandText;
            int recCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return recCount;
        }

        /// <summary>
        /// This method accepts a sqlcommand and displays the record
        /// </summary>
        /// <param name="sqlCommand"></param>
        private static void GetRecords(SqlCommand sqlCommand)
        {
            Console.ForegroundColor = ConsoleColor.White;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader.GetInt32(0) + "," + sqlDataReader.GetString(1));
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************");
        }
    }
}

/*1) create a table employee with a column ID,Name,Salary  enter the record using sql connection class connect to the database and display records
sol:*/
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
namespace ADO01_ConsoleApplication
{
    public class Class1
    {
        private string _connectionString;
        public Class1(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void Products()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // Pass the connection to the command object, so the command object knows on which
                // connection to execute the command
                SqlCommand cmd = new SqlCommand("Select * from Nora", con);
                // Open the connection. Otherwise you get a runtime error. An open connection is
                // required to execute the command            
                con.Open();
                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
                    }
                }
            }

        }
    }
}
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
namespace ADO01_ConsoleApplication
{
    public class Class1
    {
        private string _connectionString;
        public Class1(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void Products()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // Pass the connection to the command object, so the command object knows on which
                // connection to execute the command
                SqlCommand cmd = new SqlCommand("Select * from Nora", con);
                // Open the connection. Otherwise you get a runtime error. An open connection is
                // required to execute the command            
                con.Open();
                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
                    }
                }
            }

        }
    }
}


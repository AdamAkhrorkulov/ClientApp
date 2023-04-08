using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Person.Client;

namespace Student.Client
{
    public class Program
    {

        static void Main(string[] args)
        {
            var c = new Client();
            var res = c.GetData();

            Console.WriteLine(res);


        }


        public static void GetData()
        {
            //Create the object of SqlConnection class to connect with database sql server
            using (var conn = new SqlConnection())
            {
                //prepare connection string
                conn.ConnectionString = "server=localhost; database=DemoDb; Integrated Security=True; TrustServerCertificate=True";

                try
                {

                    //Prepare SQL command that we want to query
                    var cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    // cmd.CommandText = "SELECT * FROM Students";
                    cmd.CommandText = "SELECT * FROM Persons";
                    cmd.Connection = conn;

                    // open database connection.
                    conn.Open();

                    Console.WriteLine("Connection Open ! ");

                    //Execute the query 
                    var sdr = cmd.ExecuteReader();

                    ////Retrieve data from table and Display result
                    while (sdr.Read())
                    {
                        String Name = (string)sdr["Name"];
                        Console.WriteLine(Name);
                    }
                    //Close the connection
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !");

                }

            }
        }
    }
}

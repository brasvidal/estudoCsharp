using System;
using Microsoft.Data.SqlClient;
namespace BaltaDataAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            const string connectionString =
             "Server=localhost,1433;Database=balta;User Id=sa;Password=na0lembr0;";


            using (var connection = new SqlConnection(connectionString))
            {


            }


        }
    }
}

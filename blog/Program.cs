using System;
using Blog.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=Localhost,1433
        ;Database=Blog,User ID=sa;Password=na0lembr0";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadUsers();
        }



        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
    }
}

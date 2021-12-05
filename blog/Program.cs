using System;
using Blog.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Blog.Repositories;

namespace blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=Localhost,1433;Database=Blog;User Id=sa;Password=na0lembr0;Encrypt=False;TrustServerCertificate=False";
        static void Main(string[] args)
        {
            var repository = new UserRepository();

            repository.Get();
            var users = repository.Get();

            Console.WriteLine("Hello World!");

        }



    }
}

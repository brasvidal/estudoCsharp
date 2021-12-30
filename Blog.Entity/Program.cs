using System;
using System.Linq;
using Blog.Entity.Data;
using Blog.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                //Gravar dados no banco

                // var tag = new Tag
                // {
                //     Name = "Internet Basico",
                //     Slug = "internet basico"
                // };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                //Update
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = "Linha modificada 1";
                // tag.Slug = "Linha Modificada 1 slug";
                // context.SaveChanges();

                // //Delete
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();

                //Read-Select
                var tags = context.Tags
                .Where(x => x.Name.Contains("N"))
                .AsNoTracking()// <<< sempre utilizar quando for fazer select, nunca quando update ou delete
                .ToList(); //TOLIST é SEMPRE O ULTIMO METODO SEMPRE!!!!!

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }


                Console.WriteLine("Fim");

            }

        }
    }
}

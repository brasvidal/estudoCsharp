using System;
using System.Collections.Generic;
using OOProjetoTeste.ContentContext;

namespace OOProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre Classes", "orientacao-classes"));
            articles.Add(new Article("Artigo sobre Azure", "azure-na-web"));
            articles.Add(new Article("Artigo sobre Automação Comercial", "automacao-comercial"));


            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("---------");
            }
            var courses = new List<Course>();
            var courseoop = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Arquitetura de Computadores", "arquitetura");
            var courseAspNet = new Course("Fundamentos OOP", "fundamentos-oop");
            courses.Add(courseoop);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);
            foreach (var carer in careers)
            {
                Console.WriteLine(careerDotNet.Title);
                foreach (var item in careerDotNet.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }

            }



        }
    }
}

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
        }
    }
}

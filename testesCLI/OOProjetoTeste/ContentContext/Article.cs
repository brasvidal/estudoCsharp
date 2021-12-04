using System.Collections.Generic;
using OOProjetoTeste.NotificationContext;

namespace OOProjetoTeste.ContentContext
{
    public class Article : Content

    {
        public IList<Notification> Notifications { get; set; }
        public Article(string title, string url)
        : base(title, url)
        {

        }
    }
}

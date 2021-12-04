using System.Collections.Generic;

namespace OOProjetoTeste.ContentContext
{


    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Module(string title, string url)
        : base(title, url) => Lectures = new List<Lecture>();
    }

}

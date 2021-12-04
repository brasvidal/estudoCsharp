using System.Collections;
using System.Collections.Generic;

namespace OOProjetoTeste.ContentContext
{

    public class Course : Content
    {

        public Course(string title, string url)
        : base(title, url) => Modules = new List<Module>();
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

    }

}

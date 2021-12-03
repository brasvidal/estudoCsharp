using System.Collections;
using System.Collections.Generic;

namespace OOProjetoTeste.ContentContext
{

    public Course()
    {
        Modules = new List<Module>();
    }
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

    }
    public class Module
    {
        //
    }
}

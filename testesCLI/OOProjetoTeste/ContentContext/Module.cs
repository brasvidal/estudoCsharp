using System.Collections.Generic;

namespace OOProjetoTeste.ContentContext
{


    public class Module : Content
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Module() => Lectures = new List<Lecture>();
    }

}

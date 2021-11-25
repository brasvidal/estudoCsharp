using System;

namespace Vidal.UI.AppModelo.Models
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; } 
        public string Name { get; set; }
        public double Grades { get; set; }
        public int Period { get; set; }
    }
}

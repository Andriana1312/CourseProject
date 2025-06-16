using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CoursePartTwo
{
    public class Student
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Specializare { get; set; }

        public Student(string nume,int varsta,string specializare)
        {
            Nume=nume;
            Varsta=varsta;
            Specializare=specializare;
        }
        public Student(Student original) 
        {
            Nume=original.Nume;
            Varsta=original.Varsta;
            Specializare=original.Specializare;
        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Student:{Nume}, {Varsta} ani, specializare: {Specializare}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.Inheritance
{
    public class Angajat
    {
        public string Nume { get; set; }

        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Angajat: {Nume}.");
        }

        public Angajat(string nume)
        {
            Nume = nume;
        }
    }

    public class Manager : Angajat
    {
        public string Departament { get; set; }
        public Manager(string nume, string departament) : base(nume)
        {
            Departament = departament;
        }
        public override void AfisareDetalii()
        {
            Console.WriteLine($"Angajat: {Nume}, Departament: {Departament}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public class Carte
    {
        public string Titlu {  get; set; }
        public string Autor { get; set; }
        public int AnPublicare { get; set; }
        public int NumarPagini { get; set; }

        public Carte(string titlu,string autor,int anPublicare,int numarPagini)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicare = anPublicare;
            NumarPagini = numarPagini;     
        }

        public void AfisareDetalii() 
        {
            Console.WriteLine($"Cartea:{Titlu}, autor: {Autor}, anul publicarii:{AnPublicare}, nr de pagini: {NumarPagini}");
        }

    }
}

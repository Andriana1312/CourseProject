using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public class Colet
    {
        public int ID { get;}
        private string destinatar;
        private string adresa;
        private double greutatea;

        public string Destinatar
        {
            get => destinatar;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinatar = value;
            }
        }

        public string Adresa
        {
            get => adresa;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    adresa = value;
            }
        }

        public double Greutatea
        {
            get => greutatea;
            set
            {
                if (value > 0)
                    greutatea = value;
            }
        }

        public Colet(int id, string destinatar,string adresa,double greutatea)
        {
            ID = id;
            Destinatar = destinatar;
            Adresa = adresa;
            Greutatea = greutatea;
        }

    }
}

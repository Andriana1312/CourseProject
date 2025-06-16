using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public static class Helper
    {
        public static string GenerareCodUnic(string prefix)
        {
            int nrAleatoriu = new Random().Next(1000,10000);
            return $"{prefix}-{nrAleatoriu}";
        }
    }
}

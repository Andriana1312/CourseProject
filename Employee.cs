using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculateAnnualSalary()
        {
            decimal annualSalary = Salary * 12;
            Console.WriteLine($"Salariul anual al angajatului: {Name} este {annualSalary} lei");
        }
    }

    public class FullTimeEmployee :Employee
    {
        public decimal Bonus { get; set; }
        public override void CalculateAnnualSalary()
        {
            decimal annualSalary = (Salary * 12) + Bonus;
            Console.WriteLine($"Salariul anual al angajatului FullTime: {Name} este {annualSalary} lei.");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursPerWeek { get; set; }
        public override void CalculateAnnualSalary()
        {
            decimal annualSalary = HourlyRate * HoursPerWeek * 52;
            Console.WriteLine($"Salariul anual al angajatului PartTime: {Name} este {annualSalary} lei.");
        }
    }
}

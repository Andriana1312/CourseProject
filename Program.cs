using CoursePartTwo.Inheritance;

namespace CoursePartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson15,Ex1,AfisareClasaAngajat

            //Angajat angajat1 = new Angajat("Onea Andriana",15300,"DTI");
            //angajat1.AfisareDetalii();
            //Console.WriteLine();
            //Angajat angajat2 = new Angajat("Babin Stefani", 13250, "Marketing");
            //angajat2.AfisareDetalii();
            //Console.WriteLine();
            //Angajat angajat3 = new Angajat("Tcacenco Ion", 18200, "Legalitate");
            //angajat3.AfisareDetalii();
            //Console.WriteLine();

            #endregion

            #region Lesson16,Ex.1,EmployeeManager

            //List<Employee> angajati = new List<Employee>();

            //angajati.Add(new FullTimeEmployee
            //{
            //    Name = "Maria Onea",
            //    EmployeeID = 1,
            //    Salary = 10250,
            //    Bonus = 10000
            //});

            //angajati.Add(new PartTimeEmployee
            //{
            //    Name = "Ion Tcaciuc",
            //    EmployeeID = 2,
            //    HourlyRate = 75,
            //    HoursPerWeek = 20
            //});

            //angajati.Add(new PartTimeEmployee
            //{
            //    Name="Andriana Onea",
            //    EmployeeID = 3,
            //    HourlyRate = 70,
            //    HoursPerWeek = 20
            //});

            //foreach (Employee angajat in angajati)
            //{
            //    angajat.CalculateAnnualSalary();
            //}
            #endregion

            #region Lesson17,Ex.1,UtilizareaClaseiStatice

            //while (true)
            //{
            //    Console.WriteLine("Introduceti prefixul:");
            //    string cod = Helper.GenerareCodUnic(Console.ReadLine());
            //    Console.WriteLine($"Cod unic generat: {cod}.");
            //    Console.WriteLine();
            //}

            #endregion

            #region Lesson17,Ex.2,TestClasaCarte

            //Carte carte = new Carte("Amintiri din copilarie", "Ion Creanga", 1881, 336);
            //carte.AfisareDetalii();

            #endregion

            #region Lesson17,Ex.3,ConstructorDeCopiere

            //Student firstStudent = new Student("Ion Andres", 20, "IT");
            //Student secondStudent = new Student(firstStudent);
            //firstStudent.Nume = "Andriana Onea";
            //firstStudent.Varsta = 19;
            //firstStudent.Specializare = "Finante si banci";
            //Console.WriteLine("Student original:");
            //firstStudent.AfisareDetalii();
            //Console.WriteLine();
            //Console.WriteLine("Student copiat:");
            //secondStudent.AfisareDetalii();
            //Console.WriteLine();

            #endregion

            #region Lesson18,Inheritance-Manager:Angajat

            //Manager manager=new Manager("Babin Eugen", "Contabilitate");
            //manager.AfisareDetalii();

            #endregion

          


        }
    }
}

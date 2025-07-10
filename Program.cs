using CoursePartTwo.AplicatieMesagerie_Lesson_20;
using CoursePartTwo.Delivery;
using CoursePartTwo.Inheritance;
using CoursePartTwo.Lesson_22_PriorityQueue;
using CoursePartTwo.Lesson_23_Book_LINQ;
using CoursePartTwo.Lesson_24_SOLID_ClasaOrder;
using CoursePartTwo.Lesson_25_SOLID_IWorker;
using System.Linq;
using System.Reflection;


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

            #region Lesson19,SistemGestionareLivrari

            //var colet1 = new Colet(1256, "Ion Popescu", "Str. Libertatii 45", 2.5);
            //var droneDelivery = new DroneDelivery();
            //var deliveryManager1 = new DeliveryManager(droneDelivery);
            //deliveryManager1.ProcessDelivery(colet1);

            //var colet2 = new Colet(2658, "Maria Ionescu", "Bd.Unirii 12", 5.0);
            //var humanDelivery = new HumanDelivery();
            //var deliveryManager2 = new DeliveryManager(humanDelivery);
            //deliveryManager2.ProcessDelivery(colet2);

            #endregion

            #region Lesson20,Mesagerie

            //List<Notification> notifications = new List<Notification>
            //{
            //new EmailNotification("andr13@mail.ru", "Mesaj important!"),
            //new SMSNotification("+37368993200", "Mesaj SMS pentru Utilizator"),
            //new PushNotification("user1312", "Ai o notificare nouă!"),
            //new InAppNotification("local_user", "Notificare internă."),
            //new SMSNotification("+37368769502", "Mesaj SMS pentru user"),
            //new InAppNotification("admin_creator", "Alerta!"),
            //};

            //NotificationService.SendAll(notifications);

            //Console.WriteLine("\n Generare raport:");

            //NotificationService.GenerateReport(notifications);
            //Console.WriteLine();

            ///// Pentru a testa SendUrgent
            //var email = new EmailNotification("andr13@mail.ru", "Mesaj important!");
            //email.Send();
            //email.SendUrgent("Mesaj urgent simplu");
            //email.SendUrgent("Mesaj urgent cu retry", 3);
            //email.SendUrgent("Mesaj urgent pentru admin", true);

            #endregion

            #region Lesson21,MathOperations

            //var mathInt = new MathOperations<int>();

            //int a = 2;
            //int b = 6;

            //Console.WriteLine($"Pentru: {a} si {b}");
            //Console.WriteLine($"Add: {mathInt.Add(a, b)}");
            //Console.WriteLine($"Subtract: {mathInt.Subtract(a, b)}");
            //Console.WriteLine($"Multiply: {mathInt.Multiply(a, b)}");
            //try
            //{
            //    Console.WriteLine($"Divide:{mathInt.Divide(a, b)}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Divide: Error - {ex.Message}");
            //}
            //Console.WriteLine();

            //var mathDouble = new MathOperations<double>();

            //double s = 10.25;
            //double f = 2.5;

            //Console.WriteLine($"Pentru: {s} si {f}");
            //Console.WriteLine($"Add: {mathDouble.Add(s, f)}");
            //Console.WriteLine($"Subtract: {mathDouble.Subtract(s, f)}");
            //Console.WriteLine($"Multiply: {mathDouble.Multiply(s, f)}");
            //try
            //{
            //    Console.WriteLine($"Divide:{mathDouble.Divide(s, f)}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Divide: Error - {ex.Message}");
            //}
            //Console.WriteLine();
            #endregion

            #region Lesson22,PriorityQueue

            //var intQueue = new PriorityQueue<int>();

            //intQueue.Enqueue(10, 2);
            //intQueue.Enqueue(5, 5);  
            //intQueue.Enqueue(7, 3);

            //intQueue.DisplayQueue();

            //Console.WriteLine();
            //Console.WriteLine("Peek: " + intQueue.Peek());
            //Console.WriteLine();

            //while (!intQueue.IsEmpty())
            //{
            //    Console.WriteLine("Dequeued (int): " + intQueue.Dequeue());
            //}

            //if (intQueue.IsEmpty())
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Queue is empty!");
            //}

            //try
            //{
            //    intQueue.Peek();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    intQueue.Dequeue();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine();


            //var stringQueue = new PriorityQueue<string>();

            //stringQueue.Enqueue("fructe", 5);
            //stringQueue.Enqueue("lactate", 13);
            //stringQueue.Enqueue("electrocasnice", 21);

            //stringQueue.DisplayQueue();

            //Console.WriteLine();
            //Console.WriteLine("Peek: " + stringQueue.Peek());
            //Console.WriteLine();

            //while (!stringQueue.IsEmpty())
            //{
            //    Console.WriteLine("Dequeued (string): " + stringQueue.Dequeue());
            //}

            //if (intQueue.IsEmpty())
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Queue is empty!");
            //}

            //try
            //{
            //    stringQueue.Peek();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    stringQueue.Dequeue();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Lesson23,Book_LINQ
            //List<Book> books = new List<Book>{
            // new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet", Year = 2019, CopiesAvailable = 5 },
            // new Book { Id = 2, Title = "Pro C# 7", Author = "Andrew Troelsen", Year = 2018, CopiesAvailable = 2 },
            // new Book { Id = 3, Title = "C# 6.0 and the .NET 4.6 Framework", Author = "Andrew Troelsen", Year = 2015, CopiesAvailable = 0 },
            // new Book { Id = 4, Title = "Learning C# by Developing Games", Author = "Harrison Ferrone", Year = 2020, CopiesAvailable = 4 },
            // new Book { Id = 5, Title = "CLR via C#", Author = "Jeffrey Richter", Year = 2012, CopiesAvailable = 1 }
            //};

            //// Găsește toate cărțile scrise de "Andrew Troelsen".
            //var result = books
            //    .Where(book => book.Author == "Andrew Troelsen");
            //Console.WriteLine("Books by Andrew Troelsen: ");
            //foreach (var book in result)
            //{
            //    Console.WriteLine($"Title:{book.Title}, year: {book.Year}.");
            //}
            //Console.WriteLine();

            //// Ordoneaza toate cartile dupa anul publicarii, descrescator.
            //var orderedBooks = books
            //    .OrderByDescending(book => book.Year);
            //Console.WriteLine("Books ordered by year:");
            //foreach (var book in orderedBooks)
            //{
            //    Console.WriteLine($"Title:{book.Title},Author:{book.Author} year: {book.Year}.");
            //}
            //Console.WriteLine();

            ////Creeaza o lista de titluri ale cartilor care au cel puțin o copie disponibila.
            //var copiedBooks = books
            //    .Where(book => book.CopiesAvailable > 0)
            //    .Select(book => book.Title).ToList();
            //Console.WriteLine("Books with Available Copies >0:");
            //foreach (var title in copiedBooks)
            //{
            //    Console.WriteLine(title);
            //}
            //Console.WriteLine();

            ////Calculeaza numarul total de copii disponibile în bibliotecă.
            //var nrCopii = books
            //    .Sum(book => book.CopiesAvailable);
            //Console.WriteLine($"Numarul total de copii disponibile:{nrCopii}");
            //Console.WriteLine();

            ////Gaseste autorii unici din colectie.
            //var authorUnic = books
            //    .Select(book => book.Author)
            //    .Distinct().ToList();
            //Console.WriteLine("Autori Unici:");
            //foreach (var author in authorUnic)
            //{
            //    Console.WriteLine(author);
            //}
            //Console.WriteLine();

            ////Obtine a doua pagina de rezultate, cu cate 2 carti pe pagina, ordonate dupa titlu.
            //var orderedByTitle = books
            //    .OrderBy(book => book.Title);
            //var booksFirstPage = orderedByTitle.Skip(0).Take(2).ToList();
            //var booksSecondPage = orderedByTitle.Skip(2).Take(2).ToList();

            //Console.WriteLine($"Prima pagina:");
            //foreach (var book in booksFirstPage)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Author}");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"A doua pagina:");
            //foreach (var book in booksSecondPage)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Author}");
            //}
            //Console.WriteLine();

            #endregion

            #region Lesson24,RescriereaClaseiOrder(SOLID)

            //var orderManager = new OrderManager();

            //var order = new Order { Id = 1, Amount = 20 };

            //orderManager.SaveToDatabase(order);

            //orderManager.LoadFromDatabase(1);


            #endregion

            #region Lesson25,SOLID_PART_TWO

            //HumanWorker human = new HumanWorker();
            //RobotWorker robot = new RobotWorker();

            //human.Work();
            //human.Eat();
            //robot.Work();

            #endregion

           
        }
    }
}

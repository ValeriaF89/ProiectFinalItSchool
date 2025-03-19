
using static CatalogBackEnd.StudentFactory;

namespace CatalogBackEnd
{
    public static class StudentFactory
    {

        // Lista de elevi
        public static List<Student> student { get; private set; } = new List<Student>();

        // Constructor static care populează lista cu date de exemplu
        static StudentFactory()
        {
            
            PopulateMockupData();
        }

        // Metodă pentru popularea datelor prestabilite
        public static void PopulateMockupData()
        {
           
            student.Add(new Student("Ion Popescu", new List<string> { "Matematica", "Lb Romana", "Informatica" })
            {
                Note = new Dictionary<string, List<int>>()
            {
                { "Matematica", new List<int> { 8, 9, 10 } },
                { "Lb Romana", new List<int> { 7, 8, 9 } },
                { "Informatica", new List<int> { 10, 10, 9 } }
                }
            });

            student.Add(new Student("Marian Ionescu", new List<string> { "Matematica", "Lb Romana", "Informatica" })
            {
                Note = new Dictionary<string, List<int>>()
            {
                { "Matematica", new List<int> { 6, 6, 5 } },
                { "Lb Romana", new List<int> { 9, 9, 8 } },
                { "Informatica", new List<int> { 10, 10, 10 } }
                }
            });

            student.Add(new Student("Andreas Vasilescu", new List<string> { "Matematica", "Lb Romana", "Informatica" })
            {
                Note = new Dictionary<string, List<int>>()
            {
                { "Matematica", new List<int> { 7, 7, 9 } },
                { "Lb Romana", new List<int> { 8, 8, 8 } },
                { "Informatica", new List<int> { 9, 9, 9 } }
                }
            });

            student.Add(new Student("Petru Petrovici", new List<string> { "Matematica", "Lb Romana", "Informatica" })
            {
                Note = new Dictionary<string, List<int>>()
            {
                { "Matematica", new List<int> { 8, 7, 6 } },
                { "Lb Romana", new List<int> { 8, 7, 6 } },
                { "Informatica", new List<int> { 7, 7, 8 } }
                }
            });

            student.Add(new Student("Lucia Bata", new List<string> { "Matematica", "Lb Romana", "Informatica" })
            {
                Note = new Dictionary<string, List<int>>()
            {
                { "Matematica", new List<int> { 10, 9, 9 } },
                { "Lb Romana", new List<int> { 9, 8, 7 } },
                { "Informatica", new List<int> { 10, 10, 9 } }
            }
            });
        }
        public static void AdaugaElev(string numeElev, List<string> materii)
        {
            if (string.IsNullOrWhiteSpace(numeElev))
            {
                throw new ArgumentException("Numele elevului nu poate fi gol.");
            }

            if (student.Any(s => s.Name.Equals(numeElev, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Elevul există deja în catalog.");
            }

            student.Add(new Student(numeElev, materii));
        }
        // Clasa care reprezintă un elev, cu nume și note grupate pe materii
        public class Student
        {
            public string Name { get; set; } // Numele elevului
            public Dictionary<string, List<int>> Note { get; set; } // Dct cu materii și liste de note

            // Constructor care initializeaza numele și lista de materii cu note goale
            public Student(string nume, List<string> materii)
            {
                Name = nume;
                Note = materii.ToDictionary(m => m, m => new List<int>());
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                // Lista prestablita de elevi și materii
                var catalog = new List<Student>
            {
                new Student("Ion Popescu", new List<string> {"Matematica", "Lb Romana", "Informatica"}),
                new Student("Marian Ionescu", new List<string> {"Matematica", "Lb Romana", "Informatica"}),
                new Student("Andreas Vasilescu", new List<string> {"Matematica", "Lb Romana", "Informatica"}),
                new Student("Petru Petrovici", new List<string>{"Matematica", "Lb Romana", "Informatica"}),
                new Student("Lucia Bata", new List<string>{"Matematica", "Lb Romana", "Informatica"})
            };

                // Meniul care apare utilizatorlui
                while (true)
                {
                    Console.WriteLine("                                           Catalog Digital");
                    Console.WriteLine("Catalogul va permite vizualizarea elevilor dar si mediile si notele lor. Aplicatia va mai permite si adaugarea notelor in catalog");
                    Console.WriteLine();
                    Console.WriteLine("1. Afisează notele elevilor");
                    Console.WriteLine("2. Adaugă o notă");
                    Console.WriteLine("3. Afisează media fiecărui stundets");
                    Console.WriteLine("4. Afisează media clasei");
                    Console.WriteLine("0. Exit");

                    Console.Write("Selecteaza o optiune: ");
                    var input = Console.ReadLine();


                    //verificare daca se introduce numarul corect cerut in meniu
                    if (!int.TryParse(input, out int GetNumber) && (GetNumber < 1 || GetNumber > 5))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Optiune invalida. Incearca din nou.");
                        continue;

                    }//verificat


                    switch (input)
                    {
                        case "1":
                            ShowGrades(catalog);
                            break;
                        case "2":
                            AddGrade(catalog);
                            break;
                        case "3":
                            GetAvarageOfStudents(catalog);
                            break;
                        case "4":
                            GetAvarageOfClass(catalog);
                            break;
                        case "0":
                            return;

                    }
                }   //verificat
            }

            // Metoda pentru afisarea notelor elevilor
            static void ShowGrades(List<Student> catalog)
            {
                foreach (var stundets in catalog)
                {

                    Console.WriteLine($"Elev: {stundets.Name}");
                    foreach (var subject in stundets.Note.Keys)
                    {
                        var grade = string.Join(", ", stundets.Note[subject]);
                        Console.WriteLine($"  {subject}: {grade}");
                    }
                }

            }//verificat


            
            static void AddGrade(List<Student> catalog)
            {
                Console.Clear();
                Console.Write("Introdu numele elevului: ");

                var studentName = Console.ReadLine();

                var stundet = catalog.FirstOrDefault(e => e.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

                if (stundet == null)
                {
                    Console.WriteLine("Elevul nu a fost gasit.");
                    return;
                }

                Console.Write("Introdu materia: ");
                var materie = Console.ReadLine();
                if (!stundet.Note.ContainsKey(materie))
                {
                    Console.WriteLine("Materia nu a fost gasită.");
                    return;
                }

                Console.Write("Introdu nota: ");
                if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 1 && nota <= 10)
                {
                    stundet.Note[materie].Add(nota);
                    Console.WriteLine("Nota a fost adaugată cu succes.");
                }
                else
                {
                    Console.WriteLine("Nota introdusa nu este valida. Introdu o valoare între 1 și 10.");
                }
            }

         
            static void GetAvarageOfStudents(List<Student> catalog)
            {
                foreach (var elev in catalog)
                {
                    double media = elev.Note.Values.SelectMany(n => n).DefaultIfEmpty(0).Average();
                    Console.WriteLine($"Elevul: {elev.Name}, Media: {media:F2}");
                }
            }

           
            static void GetAvarageOfClass(List<Student> catalog)
            {
                var toateNotele = catalog.SelectMany(e => e.Note.Values.SelectMany(n => n)).ToList();
                double mediaClasei = toateNotele.DefaultIfEmpty(0).Average();
                Console.WriteLine($"Media clasei: {mediaClasei:F2}");
            }
        }

    }
}

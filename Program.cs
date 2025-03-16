 namespace ConsoleApp2
 {
        internal class Program
        {
            class Student
            {
                public string Name { get; set; }
                public string Surname { get; set; }
                public string Group { get; set; }
                public int Point { get; set; }
                public bool IsGraduated { get; set; }
                public Student(string name, string surname, string group, int point)
                {
                    Name = name;
                    Surname = surname;
                    Group = group;
                    Point = point;
                    IsGraduated = point >= 65;
                }
                public void Getinfo()
                {
                    Console.WriteLine($"Name: {Name}");
                    Console.WriteLine($"Surname: {Surname}");
                    Console.WriteLine($"Group: {Group}");
                    Console.WriteLine($"Point: {Point}");
                    Console.WriteLine($"IsGraduated: {(IsGraduated ? "Yes" : "No")}");
                }
                public void CheckGraduated()
                {
                if (IsGraduated)
                    Console.WriteLine($"{Name} {Surname} mezun olub.");
                else
                    Console.WriteLine($"{Name} {Surname} mezun olmayib");
                }
                class Program
                {
                    static void Main()
                    {
                        Student student1 = new Student("Roya", "Huseynova", "R25", 75);
                        student1.Getinfo();
                        Console.WriteLine();
                        Student student2 = new Student("Asiman", "Aliyev", "R25", 55);
                        student2.Getinfo();
                    }
                }
            }
        }
 }





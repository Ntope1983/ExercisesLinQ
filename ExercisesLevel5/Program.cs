internal class Program
{
    private static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        Exercise4();
    }
    public static void Exercise1()
    {
        int[] numbers = new int[] { 10, 88, 13, 42, 21 };
        var result = numbers.Where(n => n % 2 == 1);
        foreach (int odd in result)
        {
            Console.WriteLine(odd);
        }
    }
    public static void Exercise2()
    {
        List<Student> students = new List<Student>
        {
            new Student("Polidoras", 100, 42),
            new Student("Laiou", 85, 46),
            new Student("Ladias", 26, 44),
            new Student("Lakis", 10, 65),
            new Student("Papadopulos", 7, 42)
        };
        var result = students.Where(n => n.studentGrade > 80);
        foreach (Student st in result)
        {
            Console.WriteLine($"The student with name {st.studentName} has grade {st.studentGrade}");
        }
    }
    public static void Exercise3()
    {
        List<Student> students = new List<Student>
        {
            new Student("Polidoras", 100, 42),
            new Student("Laiou", 85, 46),
            new Student("Ladias", 26, 44),
            new Student("Lakis", 10, 65),
            new Student("Papadopulos", 7, 42)
        };
        var avg = students.Average(n => n.studentGrade);
        var max = students.Max(n => n.studentGrade);
        Console.WriteLine($"The max grade from students is {max} \nThe Average grade from students is {avg}");
    }
    public static void Exercise4()
    {
        List<Student> students = new List<Student>
        {
            new Student("Polidoras", 100, 42),
            new Student("Laiou", 85, 46),
            new Student("Ladias", 26, 44),
            new Student("Lakis", 10, 65),
            new Student("Papadopulos", 7, 42)
        };
        var result2 = students.OrderBy(n => n.studentAge);
        foreach (Student st in result2)
        {
            Console.WriteLine($"Student:{st.studentName}\nGrade:{st.studentGrade}  Age:{st.studentAge}");
        }
        var result = students.GroupBy(n => n.studentAge);
        foreach (var group in result)
        {
            Console.WriteLine($"Age: {group.Key}");

            foreach (var student in group)
            {
                Console.WriteLine($" - {student.studentName}");
            }
        }
        string[] emails = ["g_poly1@yahoo.gr", "g_poly2@yahoo.gr", "g_poly3@yahoo.gr", "g_poly4@yahoo.gr", "g_poly5@yahoo.gr"];

        Dictionary<string, Student> emailStudents = new Dictionary<string, Student>();
        int emailIndex = 0;
        foreach (Student st in students)
        {
            emailStudents.Add(emails[emailIndex], st);
            emailIndex++;
        }
        foreach (var item in emailStudents)
        {
            Console.WriteLine("Key: " + item.Key);
            Console.WriteLine("Value: " + item.Value.studentName);
        }
    }
    public class Student
    {
        public string studentName { get; set; }
        public int studentGrade { get; set; }
        public int studentAge { get; set; }
        public Student(string Name, int grade, int age)
        {
            studentName = Name;
            studentGrade = grade;
            studentAge = age;
        }
    }
}



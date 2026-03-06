internal class Program
{
    private static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        Exercise3();
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
        List<Student> students = [new Student("Polidoras", 100), new Student("Laiou", 85), new Student("Ladias", 26), new Student("Lakis", 10), new Student("Papadopulos", 70)];
        var result = students.Where(n => n.studentGrade > 80);
        foreach (Student st in result)
        {
            Console.WriteLine($"The student with name {st.studentName} has grade {st.studentGrade}");
        }
    }
    public static void Exercise3()
    {
        List<Student> students = [new Student("Polidoras", 100), new Student("Laiou", 85), new Student("Ladias", 26), new Student("Lakis", 10), new Student("Papadopulos", 70)];
        var avg = students.Average(n => n.studentGrade);
        var max = students.Max(n => n.studentGrade);
        Console.WriteLine($"The max grade from students is {max} \nThe Average grade from students is {avg}");
    }
    public class Student
    {
        public string studentName { get; set; }
        public int studentGrade { get; set; }
        public Student(string Name, int grade)
        {
            studentName = Name;
            studentGrade = grade;
        }
    }
}



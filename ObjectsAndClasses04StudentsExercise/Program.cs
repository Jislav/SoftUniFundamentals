namespace ObjectsAndClasses04StudentsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentInfo = Console.ReadLine();

                string[] tokens = studentInfo.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);
                
                Student currentStudent = new Student(firstName, lastName, grade);
                students.Add(currentStudent);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
        class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
    }
}

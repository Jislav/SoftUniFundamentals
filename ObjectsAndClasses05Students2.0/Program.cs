namespace ObjectsAndClasses05Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = String.Empty;

            List<Students> students = new List<Students>();

            while ((line = Console.ReadLine()) != "end")
            {
                string[] studentTokens = line.Split();
               
                string firstName = studentTokens[0];
                string secondName = studentTokens[1];
                int age = int.Parse(studentTokens[2]);
                string homeTown = studentTokens[3];

                Students student = IsStudentExisting(students, firstName, secondName);
                if (student == null)
                {
                    students.Add(new Students
                    {
                        FirstName = firstName,
                        SecondName = secondName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }

            string town = Console.ReadLine();

            foreach (Students hometownStudent in students)
            {
                if (hometownStudent.HomeTown == town)
                {
                    Console.WriteLine($"{hometownStudent.FirstName} {hometownStudent.SecondName} is {hometownStudent.Age} years old.");
                }
            }
        }

        private static Students? IsStudentExisting(List<Students> students, string firstName, string secondName)
        {
            Students student = null;
            foreach(Students s in students)
            {
                if(s.FirstName == firstName && s.SecondName == secondName)
                {
                    student = s;
                }
            }

            return student;
        }

        class Students
        {
            public string FirstName { get; set; }

            public string SecondName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }

        }
    }
}

namespace ObjectsAndClasses04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student = String.Empty;

            List<Students> students = new List<Students>();

            while((student = Console.ReadLine()) != "end")
            {
                string[] studentTokens = student.Split();

                string firstName = studentTokens[0];
                string secondName = studentTokens[1];
                int age = int.Parse(studentTokens[2]);
                string homeTown = studentTokens[3];

                Students currentStudent = new Students();

                currentStudent.FirstName = firstName;
                currentStudent.SecondName = secondName;
                currentStudent.Age = age;
                currentStudent.HomeTown = homeTown;

                students.Add(currentStudent);
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

        class Students
        {
            public string FirstName { get; set; }

            public string SecondName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }

        }
    }
}

namespace AssociativeArrays06StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>() { grade });
                }
            }

            
            foreach (KeyValuePair<string, List<double>> student in students)
            {
                if(student.Value.Average() < 4.50)
                {
                    students.Remove(student.Key);
                }
                else
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }

            }
        }
    }
}

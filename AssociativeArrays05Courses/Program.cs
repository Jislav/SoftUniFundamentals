namespace AssociativeArrays05Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,List<string>> courses = new Dictionary<string, List<string>>();

            string line = default;

            while((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                if (courses.ContainsKey(tokens[0]))
                {
                    foreach(KeyValuePair<string, List<string>> course in courses)
                    {
                        if(course.Key == tokens[0])
                        {
                            course.Value.Add(tokens[1]);
                        }
                    }
                }
                else
                {
                    courses.Add(tokens[0], new List<string>() {tokens[1]});
                }
            }
            foreach(KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach(string member in course.Value)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}

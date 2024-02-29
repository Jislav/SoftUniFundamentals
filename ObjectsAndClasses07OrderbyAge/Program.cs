namespace ObjectsAndClasses07OrderbyAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;

            List<Person> people = new List<Person>();

            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split();

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                bool idExists = false;

                foreach (Person person in people)
                {
                    if (person.Id == id)
                    {
                        person.Age = age;
                        person.Name = name;
                        idExists = true;
                    }
                }
                if (idExists)
                {

                }
                else
                {
                    Person currentPerson = new Person(name, id, age);
                    people.Add(currentPerson);
                }
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}

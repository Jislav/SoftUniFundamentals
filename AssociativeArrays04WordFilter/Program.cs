namespace AssociativeArrays04WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach(string item in foods)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}

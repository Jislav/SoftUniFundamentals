namespace List01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityWagon = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                command = tokens[0];
                
                if(command == "Add")
                {
                    wagons.Add(int.Parse(tokens[1]));
                }
                else
                {
                    for(int i = 0; i < wagons.Count; i++) 
                    {
                        if (wagons[i] + int.Parse(tokens[0]) <= maxCapacityWagon)
                        {
                            wagons[i] += int.Parse(tokens[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

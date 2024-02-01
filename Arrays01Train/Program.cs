namespace Arrays01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] wagons = new int[numberOfWagons];

            int total = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentWagon = int.Parse(Console.ReadLine());

                wagons[i] = currentWagon;

                total += currentWagon;
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(total);
        }
    }
}

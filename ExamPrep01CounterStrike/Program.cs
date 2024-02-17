namespace ExamPrep01CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string distance = string.Empty;

            int battlesCounter = 0;

            bool endOfBattle = true;

            while ((distance = Console.ReadLine()) != "End of battle")
            {
                int distanceInt = int.Parse(distance);

                if (distanceInt <= energy)
                {
                    energy -= distanceInt;
                    battlesCounter++;
                    if (battlesCounter % 3 == 0)
                    {
                        energy += battlesCounter;
                    }
                }
                else
                {
                    endOfBattle = false;
                    break;
                }
            }

            if (endOfBattle)
            {
                Console.WriteLine($"Won battles: {battlesCounter}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {battlesCounter} won battles and {energy} energy");
            }
        }
    }
}

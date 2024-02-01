namespace Arrays09Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            string Dna = Console.ReadLine();

            int[] DnaArray = new int[lenght];

            int index = 1;
            int bestSequenceIndex = 0;
            
            int bestSum = 0;
            int bestCount = 1;
            int[] bestDna = new int[lenght];
            int bestIndex = 0;

            while (Dna != "Clone them!")
            {
                DnaArray = Dna
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < DnaArray.Length ; i++)
                {
                    int currentCount = 1;
                    currentSum += DnaArray[i];

                    for (int j = i + 1; j < DnaArray.Length - 1; j++)
                    {
                        if (DnaArray[i] == DnaArray[j])
                        {
                            currentCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > bestCount || bestIndex > i || bestSum > currentSum)
                    {
                        bestSum = currentSum;
                        bestCount = currentCount;
                        bestDna = DnaArray;
                        bestIndex = i;
                        bestSequenceIndex = index;
                    }
                }

                currentSum = 0;
                index++;
                Dna = Console.ReadLine();
            }

            bestSum = 0;
            for (int i = 0; i < bestDna.Length; i++)
            {
                bestSum += bestDna[i];
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}

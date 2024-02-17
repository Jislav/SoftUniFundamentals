namespace ExamPrep03MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split()
                .ToList();

            int numberOfMoves = 0;

            string numbers = string.Empty;

            bool allElementsRemoved = false;

            while ((numbers = Console.ReadLine()) != "end")
            {
                string[] numbersArr = numbers.Split();

                numberOfMoves++;

                if (numbersArr[0] == numbersArr[1] || int.Parse(numbersArr[0]) > sequence.Count - 1 && int.Parse(numbersArr[1]) > sequence.Count - 1 ||
                    int.Parse(numbersArr[0]) < 0 || int.Parse(numbersArr[1]) < 0)
                {
                    sequence.Insert(sequence.Count / 2, $"-{numberOfMoves}a");
                    sequence.Insert(sequence.Count / 2 + 1, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (sequence[int.Parse(numbersArr[0])] == sequence[int.Parse(numbersArr[1])])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[int.Parse(numbersArr[0])]}!");
                    if (int.Parse(numbersArr[0]) > int.Parse(numbersArr[1]))
                    {
                        sequence.RemoveAt(int.Parse(numbersArr[0]));
                        sequence.RemoveAt(int.Parse(numbersArr[1]));
                    }
                    else
                    {
                        sequence.RemoveAt(int.Parse(numbersArr[1]));
                        sequence.RemoveAt(int.Parse(numbersArr[0]));
                    }
                }
                else if (sequence[int.Parse(numbersArr[0])] != sequence[int.Parse(numbersArr[1])])
                {
                    Console.WriteLine("Try again!");
                }

                if (sequence.Count == 0)
                {
                    allElementsRemoved = true;
                    break;
                }

            }
            if (allElementsRemoved)
            {
                Console.WriteLine($"You have won in {numberOfMoves} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }
        }
    }
}

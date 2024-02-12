namespace List06CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0)
            {
                int smallerHand = Math.Min(firstPlayerHand.Count, secondPlayerHand.Count);

                for (int i = 0; i < smallerHand; i++)
                {
                    if (firstPlayerHand[0] > secondPlayerHand[0])
                    {
                        firstPlayerHand.Add(firstPlayerHand[0]);
                        firstPlayerHand.Add(secondPlayerHand[0]);
                        firstPlayerHand.RemoveAt(0);
                        secondPlayerHand.RemoveAt(0);
                    }
                    else if (firstPlayerHand[0] < secondPlayerHand[0])
                    {
                        secondPlayerHand.Add(secondPlayerHand[0]);
                        secondPlayerHand.Add(firstPlayerHand[0]);
                        secondPlayerHand.RemoveAt(0);
                        firstPlayerHand.RemoveAt(0);
                    }
                    else
                    {
                        firstPlayerHand.RemoveAt(0);
                        secondPlayerHand.RemoveAt(0);
                    }
                }
            }
            string winner = firstPlayerHand.Count > secondPlayerHand.Count ? "First" : "Second";
            int winnerSum = winner == "First" ? firstPlayerHand.Sum() : secondPlayerHand.Sum();

            Console.WriteLine($"{winner} player wins! Sum: {winnerSum}");
        }
    }
}

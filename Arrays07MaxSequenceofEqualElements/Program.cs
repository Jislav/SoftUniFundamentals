namespace Arrays07MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            string highestSequenceElement = " ";
            int highestSequence = 0;
            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentSequence = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[i] == input[j])
                    {
                        currentSequence++;
                        if (currentSequence >= highestSequence)
                        {
                            highestSequence = currentSequence;
                            highestSequenceElement = input[j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            string[] result = new string[highestSequence];
            Array.Fill(result, highestSequenceElement);
            Console.Write(string.Join(" ", result));
        }
    }
}

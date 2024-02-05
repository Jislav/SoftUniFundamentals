namespace Arrays08MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            string neshto = "exchange 2";
            string[] neshtoArr = neshto.Split(" ").ToArray();

            for (int i = 0; i < neshtoArr.Length; i++)
            {
                Console.WriteLine(neshtoArr[1]);
            }
            Console.WriteLine(neshtoArr.ToString);
            //int magicNumber = int.Parse(Console.ReadLine());

            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = i + 1; j < input.Length; j++)
            //    {
            //        if (input[i] + input[j] == magicNumber)
            //        {
            //            Console.WriteLine($"{input[i]}  {input[j]} ");
            //        }
            //    }
            //}
        }
    }
}

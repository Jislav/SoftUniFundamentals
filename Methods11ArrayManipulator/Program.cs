using System.Text;
using System.Text.RegularExpressions;

namespace Methods11ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("exchange"))
                {
                    int index = GetIndex(command);
                    if (index > arr.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, index, arr.Length);
                    }
                }
                else if (command.Contains("max"))
                {
                    if (command.Contains("even"))
                    {
                        if (CheckForEvenNumber(arr))
                        {
                            Console.WriteLine(MaxEven(arr));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        if (CheckForOddNumber(arr))
                        {
                            Console.WriteLine(MaxOdd(arr));
                        }
                        else
                        {
                            Console.WriteLine("No Matches");
                        }
                    }
                }
                else if (command.Contains("min"))
                {
                    if (command.Contains("even"))
                    {
                        if (CheckForEvenNumber(arr))
                        {
                            Console.WriteLine(MinEven(arr));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        if (CheckForOddNumber(arr))
                        {
                            Console.WriteLine(MinOdd(arr));
                        }
                        else
                        {
                            Console.WriteLine("No Matches");
                        }
                    }
                }
                else if (command.Contains("first"))
                {
                    int index = GetIndex(command);

                    if (index > arr.Length || index < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command.Contains("even"))
                        {
                            Console.WriteLine($"[{string.Join(", ", FirstEven(arr, index))}]");
                        }
                        else if (command.Contains("odd"))
                        {
                            Console.WriteLine($"[{string.Join(", ", FirstOdd(arr, index))}]");
                        }
                    }
                }
                else if (command.Contains("last"))
                {
                    int index = GetIndex(command);

                    if (index > arr.Length || index < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command.Contains("even"))
                        {
                            Console.WriteLine($"[{string.Join(", ", LastEven(arr, index))}]");
                        }
                        else if (command.Contains("odd"))
                        {
                            Console.WriteLine($"[{string.Join(", ", LastOdd(arr, index))}]");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{PrintFinalArray(arr)}]");

        }

        static int GetIndex(string command)
        {
            string[] commandArr = command.Split();
            int index = int.Parse(commandArr[1]);
            return index;
        }

        static string PrintFinalArray(int[] arr)
        {
            string result = string.Join(", ", arr);

            return result;
        }

        static string[] LastOdd(int[] arr, int count)
        {
            int counter = 0;

            string lastOdd = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    lastOdd += $"{arr[i]} ";
                }
                if (counter == count)
                {
                    break;
                }
            }


            string[] lastOddArr = lastOdd.Trim()
                .Split()
                .ToArray();

            Array.Reverse(lastOddArr);
            return lastOddArr;
        }

        static string[] LastEven(int[] arr, int count)
        {
            int counter = 0;

            string lastEven = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    lastEven += $"{arr[i]} ";
                }
                if (counter == count)
                {
                    break;
                }
            }


            string[] lastEvenArr = lastEven.Trim()
                .Split()
                .ToArray();
            Array.Reverse(lastEvenArr);
            return lastEvenArr;
        }

        static string[] FirstOdd(int[] arr, int count)
        {
            int counter = 0;

            string firstOdd = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    firstOdd += $"{arr[i]} ";
                }
                if (counter == count)
                {
                    break;
                }
            }


            string[] firstOddArr = firstOdd.Trim()
                .Split().
                ToArray();
            return firstOddArr;
        }

        static string[] FirstEven(int[] arr, int count)
        {
            int counter = 0;

            string firstEven = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    firstEven += $"{arr[i]} ";
                }
                if (counter == count)
                {
                    break;
                }
            }


            string[] firstEvenArr = firstEven.Trim()
                .Split()
                .ToArray();
            return firstEvenArr;
        }


        static bool CheckForOddNumber(int[] arr)
        {
            bool hasOddNumber = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    hasOddNumber = true;
                }
            }

            return hasOddNumber;
        }

        static bool CheckForEvenNumber(int[] arr)
        {
            bool hasEvenNumber = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    hasEvenNumber = true;
                }
            }

            return hasEvenNumber;
        }

        static int MinOdd(int[] arr)
        {
            int minOddNumber = int.MaxValue;
            int minOddNumberIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= minOddNumber)
                    {
                        minOddNumber = arr[i];
                        minOddNumberIndex = i;
                    }
                }
            }
            return minOddNumberIndex;
        }

        static int MinEven(int[] arr)
        {
            int minEvenNumber = int.MaxValue;
            int minEvenNumberIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= minEvenNumber)
                    {
                        minEvenNumber = arr[i];
                        minEvenNumberIndex = i;
                    }
                }
            }

            return minEvenNumberIndex;
        }

        static int MaxOdd(int[] arr)
        {
            int maxOddNumberIndex = 1;
            int maxOddNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] >= maxOddNumber)
                    {
                        maxOddNumber = arr[i];
                        maxOddNumberIndex = i;
                    }
                }
            }

            return maxOddNumberIndex;
        }

        static int MaxEven(int[] arr)
        {
            int maxEvenNumber = 0;
            int maxEvenNumberIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= maxEvenNumber)
                    {
                        maxEvenNumber = arr[i];
                        maxEvenNumberIndex = i;
                    }
                }
            }

            return maxEvenNumberIndex;
        }

        static int[] Exchange(int[] arr, int index, int arrLength)
        {
            int[] elementsToIndex = arr.Take(index + 1).ToArray();
            int[] elementsAfterIndex = arr.Skip(index + 1).ToArray();

            int[] newArr = elementsAfterIndex.Concat(elementsToIndex).ToArray();
            return newArr;
        }
    }
}

using System.Security.Cryptography;

namespace ObjectsAndClasses01AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>()
            { 
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>()
            { 
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int lines = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();

           

            for (int i = 0; i < lines; i++)
            {
                int randomIndex = 0;

                randomIndex = GenerateRandomIndex(randomNumber, phrases);
                Console.Write($"{phrases[randomIndex]} ");

                randomIndex = GenerateRandomIndex(randomNumber, events);
                Console.Write($"{events[randomIndex]} ");

                randomIndex = GenerateRandomIndex(randomNumber, authors);
                Console.Write($"{authors[randomIndex]} - ");

                randomIndex = GenerateRandomIndex(randomNumber, cities);
                Console.Write($"{cities[randomIndex]}. {Environment.NewLine}");
                
            }
        }

         static int GenerateRandomIndex(Random randomNumber, List<string> currentList)
        {
            int result = randomNumber.Next(currentList.Count);
            return result;
        }
    }
}

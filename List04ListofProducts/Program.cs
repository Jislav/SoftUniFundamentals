namespace List04ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsAmount = int.Parse(Console.ReadLine());

            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < productsAmount; i++)
            {
                string productName = Console.ReadLine();
                listOfProducts.Add(productName);
            }
            listOfProducts.Sort();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listOfProducts[i]}");
            }
        }
    }
}

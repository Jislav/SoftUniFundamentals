namespace Methods05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = PrintTotalPriceOrder(product, quantity);

            Console.WriteLine($"{price:f2}");
        }

        static double PrintTotalPriceOrder(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                
                case "coffee":
                    price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1.00;
                    break;
                case "coke":
                    price = quantity * 1.40;
                    break;
                case "snacks":
                    price = quantity * 2.00;
                    break;
            }

            return price;
        }
    }
}

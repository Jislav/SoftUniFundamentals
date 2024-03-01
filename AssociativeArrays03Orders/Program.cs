namespace AssociativeArrays03Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;

            List<Product> productsPrice = new List<Product>();

            Dictionary<string, decimal> shoppingList = new Dictionary<string, decimal>();
            while((line = Console.ReadLine()) != "buy")
            {
                string[] tokens = line.Split();

                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

               

                if (shoppingList.ContainsKey(name))
                {
                    foreach(Product product in productsPrice)
                    {
                        if(product.Name == name)
                        {
                            product.Price = price;
                            break;
                        }
                    }
                    shoppingList[name] += quantity;
                }
                else
                {
                    Product product = new Product(name, price);
                    productsPrice.Add(product);
                    shoppingList.Add(name, quantity);
                }
            }

            foreach(KeyValuePair<string, decimal> product in shoppingList)
            {
                foreach(Product price in productsPrice)
                {
                    if(price.Name == product.Key)
                    {
                        Console.WriteLine($"{product.Key} -> {price.Price * product.Value:f2}");
                    }
                }
            }
        }
    }
    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}

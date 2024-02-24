namespace ObjectsAndClasses06StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = default;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox => ItemQuantity * Item.Price;

    }
}

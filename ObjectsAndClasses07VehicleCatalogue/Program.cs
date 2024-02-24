namespace ObjectsAndClasses07VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;

            List<Car> carsList = new List<Car>();
            List<Truck> truckslList = new List<Truck>();

            while((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(tokens[3]);
                    Car car = new Car(brand, model, horsePower);
                    carsList.Add(car);
                }
                else
                {
                    double weight = double.Parse(tokens[3]);
                    Truck truck = new Truck(brand, model, weight);
                    truckslList.Add(truck);
                }
            }

            truckslList = truckslList.OrderBy(x => x.Brand).ToList();
            carsList = carsList.OrderBy(x => x.Brand).ToList(); 
            Catalog catalog = new Catalog(truckslList, carsList);
            PrintVehicles();
        }

         static void PrintVehicles()
        {
            if (Catalog.Car.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in Catalog.Car)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (Catalog.Truck.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in Catalog.Truck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public  string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public  string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }

    class Catalog
    {
       
        public Catalog(List<Truck> truck, List<Car> car)
        {
            Truck = truck;
            Car = car;
        }

        public static List<Truck> Truck { get; set; }
        public static List<Car> Car { get; set; }
    }
}

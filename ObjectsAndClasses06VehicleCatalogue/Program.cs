using System.Diagnostics;

namespace ObjectsAndClasses06VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string line = default;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split();

                string vehicleType = ConvertTypeToStartWithUpperCase(tokens[0]);
                string vehicleModel = tokens[1];
                string vehicleColor = tokens[2];
                int vehicleHorsePower = int.Parse(tokens[3]);

                Vehicle vehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHorsePower);
                vehicles.Add(vehicle);
            }

            while ((line = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (line == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}{Environment.NewLine}Model: {vehicle.Model}{Environment.NewLine}" +
                            $"Color: {vehicle.Color}{Environment.NewLine}Horsepower: {vehicle.HorsePower}");
                        break;
                    }
                }
            }

            int carsCount = 0;
            int totalHorsePowerCars = 0;
            int trucksCount = 0;
            int totalHorsePowerTrucks = 0;
            bool catalogHasCars = false;
            bool catalogHasTrucks = false;

            double averageHorsePowerCars = 0;
            double averageHorsePowerTrcuks = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    totalHorsePowerCars += vehicle.HorsePower;
                    carsCount++;
                    catalogHasCars = true;
                }
                if(vehicle.Type == "Truck")
                {
                    totalHorsePowerTrucks += vehicle.HorsePower;
                    trucksCount++;
                    catalogHasTrucks = true;
                }
            }
            if(catalogHasCars)
            {
                averageHorsePowerCars = (double)totalHorsePowerCars / carsCount;
            }
            if(catalogHasTrucks)
            {
                averageHorsePowerTrcuks = (double)totalHorsePowerTrucks / trucksCount;
            }
            
           
            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrcuks:f2}.");
        }

        private static string ConvertTypeToStartWithUpperCase(string type)
        {
            string firstLetter = type[0].ToString().ToUpper();
            type = firstLetter + type.Substring(1);
            return type;
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}

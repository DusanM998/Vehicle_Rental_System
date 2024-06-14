using System;
using Vehicle_Rental_System;

namespace VehicleRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sample data
            var car = new Car { Brand = "Mitsubishi", Model = "Mirage", Value = 15000, SafetyRating = 3, Type = "Car" };
            var motorcycle = new Motorcycle { Brand = "Yamaha", Model = "YZF-R3", Value = 10000, Type = "Motorcycle" };
            var cargoVan = new CargoVan { Brand = "Ford", Model = "Transit", Value = 20000, Type = "Cargo Van" };

            var customer1 = new Customer { Name = "John Doe", Age = 30, YearsOfExperience = 10 };
            var customer2 = new Customer { Name = "Mary Johnson", Age = 20, YearsOfExperience = 2 };

            var rentalService = new RentalService();

            // Simulate rental process
            Console.WriteLine(rentalService.GenerateInvoice(car, 10, 10, customer1));
            Console.WriteLine();
            Console.WriteLine(rentalService.GenerateInvoice(motorcycle, 10, 10, customer2));
            Console.WriteLine();
            Console.WriteLine(rentalService.GenerateInvoice(cargoVan, 10, 5, customer1));
        }
    }
}

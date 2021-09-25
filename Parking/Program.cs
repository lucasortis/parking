using System;
using System.Globalization;
using Parking.Entities;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.WriteLine("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

        }
    }
}

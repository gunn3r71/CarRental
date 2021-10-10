using CarRental.Business.Entities;
using CarRental.Business.Services;
using System;
using System.Globalization;

namespace CarRental.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            var model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/mm/yyyy hh:mm):");
            var pickedAt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/mm/yyyy hh:mm):");
            var returnAt = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            var carRental = new Rental(pickedAt, returnAt, new Vehicle(model));

            Console.WriteLine("Enter price per hour:");
            var pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day:");
            var pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter tax zone (1 - Brazil, 2 - New York): ");
            var zone = byte.Parse(Console.ReadLine());
            ITaxService taxService =  (zone == 1) ? new BrazilTaxService() : new NewYorkTaxService();
            
            var rentalService = new RentalService(pricePerHour, pricePerDay, taxService);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
        }
    }
}
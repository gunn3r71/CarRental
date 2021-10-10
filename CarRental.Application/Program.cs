using CarRental.Business.Entities;
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
        }
    }
}
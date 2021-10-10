using CarRental.Business.Entities;
using System;

namespace CarRental.Business.Services
{
    public class RentalService
    {
        private readonly ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public void ProcessInvoice(Rental rental)
        {
            var duration = rental.Finish.Subtract(rental.Start);
            var basicPayment = (duration.TotalHours >= 12) ? PricePerDay * Math.Ceiling(duration.TotalDays):
                PricePerHour * Math.Ceiling(duration.TotalHours);

            var tax = _taxService.Tax(basicPayment);

            rental.SetInvoice(new Invoice(basicPayment, tax));
        }
    }
}

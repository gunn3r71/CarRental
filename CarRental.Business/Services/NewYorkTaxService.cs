using System;

namespace CarRental.Business.Services
{
    public class NewYorkTaxService : ITaxService
    {
        public double Tax(double total)
        {
            var taxRate = (total <= 100) ? (total * 0.35) : (total * 0.10);
            return taxRate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double total)
        {
            var taxRate = (total <= 100) ? (total * 0.2) : (total * 0.15);
            return taxRate;
        }
    }
}

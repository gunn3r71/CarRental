using System.Globalization;

namespace CarRental.Business.Entities
{
    public class Invoice
    {
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString() => $"Invoice:" +
                   $"\nBasic Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nTotal Payment: {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
